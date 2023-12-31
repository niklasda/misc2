﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using WatiN.Core;
using WatiN.Core.Comparers;
using WatiN.Core.Native.Windows;

namespace Agress.Logic
{
    public class MainPresenter
    {
        private IE _ie7;
        private IDictionary<string, string> _settings;

        public IE TheBrowser
        {
            get
            {
                var url = Settings["Agresso.Url"];

                if (_ie7 == null)
                {
                    WatiN.Core.Settings.AutoMoveMousePointerToTopLeft = false;

                    _ie7 = new IE(url);
                    _ie7.ShowWindow(NativeMethods.WindowShowStyle.ShowMaximized);
                }

                return _ie7;
            }
         //   set
         //   {
          //      _ie7 = value;
           // }
        }

        public bool IsLoggedIn
        {
            get
            {
                Button loginButton = TheBrowser.Button(Find.ById("Button1"));
                return !loginButton.Exists;
            }
        }


        public IDictionary<string, string> Settings
        {
            get
            {
                if (_settings == null)
                {
                    var appSettings = ConfigurationManager.AppSettings;

                    _settings = new Dictionary<string, string>(4);
                    _settings.Add("Login.UserName", appSettings.Get("Login.UserName"));
                    _settings.Add("Login.Client", appSettings.Get("Login.Client"));
                    _settings.Add("Login.Password", appSettings.Get("Login.Password"));
                    _settings.Add("Agresso.Url", appSettings.Get("Agresso.Url"));
                }

                return _settings;
            }
        }

        public bool LogIn()
        {

            var userName = Settings["Login.UserName"];
            var client = Settings["Login.Client"];
            var password = Settings["Login.Password"];

            var nameField = TheBrowser.TextField(Find.ById("_name"));
            var clientField = TheBrowser.TextField(Find.ById("_client"));
            var passwordField = TheBrowser.TextField(Find.ById("_password"));
            Button loginButton = TheBrowser.Button(Find.ById("Button1"));

            nameField.TypeText(userName);
            clientField.TypeText(client);
            passwordField.TypeText(password);
            loginButton.Click();

            var cell = TheBrowser.TableCell(Find.ByText("Det gick inte att logga in. Kontrollera uppgifterna och försök igen."));
            if (cell.Exists)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void GotoTimeRegistration()
        {
            var timeAndExpenses = TheBrowser.Frame("_menuFrame").Link(Find.ByText("Tid och utlägg"));
            timeAndExpenses.Click();

            var plusLink = TheBrowser.Frame("_menuFrame").Image(Find.BySrc("https://economy.waygroup.se/agresso/System/Images/Plus.gif"));
            while (plusLink.Exists)
            {
                plusLink.Click();
                plusLink = TheBrowser.Frame("_menuFrame").Image(Find.BySrc("https://economy.waygroup.se/agresso/System/Images/Plus.gif"));
            }

            var daily = TheBrowser.Frame("_menuFrame").Link(Find.ByText("Daglig tidregistrering"));
            daily.Click();
        }

        private void RegisterProjectDay(int rowNo, string timeCodeId, string projectId, string activityId, string description, string roleId, double day1Hours, double day2Hours, double day3Hours, double day4Hours, double day5Hours, double day6Hours, double day7Hours)
        {
            int lastDay = 1;

            double[] hours = { day1Hours, day2Hours, day3Hours, day4Hours, day5Hours, day6Hours, day7Hours };
            TextField[] tfs = { null, null, null, null, null, null, null };
            for (int i = 1; i <= 7; i++)
            {
                tfs[i - 1] = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s10_g10s93__row{0}_reg_value{1}_i", rowNo, i)));
                if (tfs[i - 1].Exists)
                {
                    lastDay = i;
                }
            }

            string currentPeriod = GetCurrentPeriodId();
            if (currentPeriod.EndsWith("_1"))
            {
                Fillout(rowNo, timeCodeId, projectId, activityId, description, roleId, tfs, hours, 1, lastDay);
            }
            else if (currentPeriod.EndsWith("_2"))
            {
                double[] hours2 = hours.Skip(7 - lastDay).Take(lastDay).ToArray();
                Fillout(rowNo, timeCodeId, projectId, activityId, description, roleId, tfs, hours2, 1, lastDay);
            }
            else
            {
                Fillout(rowNo, timeCodeId, projectId, activityId, description, roleId, tfs, hours, 1, 7);
            }
        }

        private void Fillout(int rowNo, string timeCodeId, string projectId, string activityId, string description, string roleId, TextField[] tfs, double[] hours, int startDay, int endDay)
        {
            var timeCodeField = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s10_g10s93__row{0}_timecode_i", rowNo)));
            timeCodeField.TypeText(timeCodeId);

            var projectField = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s10_g10s93__row{0}_project_i", rowNo)));
            projectField.TypeText(projectId);

            var activityField = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s10_g10s93__row{0}_activity_i", rowNo)));
            activityField.TypeText(activityId);

            var descriptionField = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s10_g10s93__row{0}_description_i", rowNo)));
            descriptionField.TypeText(description);

            var roleField = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s10_g10s93__row{0}_inc_cat_i", rowNo)));
            roleField.TypeText(roleId);



            for (int i = startDay; i <= endDay; i++)
            {
                // Have to fetch field again to avoid access denied
                var fieldNew = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s10_g10s93__row{0}_reg_value{1}_i", rowNo, i)));

                fieldNew.TypeText(hours[i - 1].ToString());
            }


            var checkField = TheBrowser.Frame("containerFrame").TableRow(Find.ById(string.Format("b_s10_g10s93__row{0}", rowNo))).Div(Find.ByClass("IENoText Image SymbolButton").And(Find.ByIndex(5)));
            var checkButton = checkField.Button(Find.ByIndex(0));
            checkButton.Click();
        }

        private int InsertNewLine()
        {

            Div row0Sum = TheBrowser.Frame("containerFrame").Div(Find.ById("b_s10_g10s93__row0_ctl01_c"));
            TextField day1Code = TheBrowser.Frame("containerFrame").TextField(Find.ById("b_s10_g10s93__row0_timecode_i"));

            if (day1Code.Exists && row0Sum.Text.Equals("0,00"))
            {
                return 0;
            }

            int i = -1;

            var newRowField = TheBrowser.Frame("containerFrame").Button(Find.ById("b_s10_g10s93__buttons__newButton"));
            newRowField.Click();

            for (int rowNo = 0; rowNo < 25; rowNo++)
            {
                var timeCodeField =
                    TheBrowser.Frame("containerFrame").TextField(
                        Find.ById(string.Format("b_s10_g10s93__row{0}_timecode_i", rowNo)));

                if (timeCodeField.Exists)
                {
                    i = rowNo;
                    break;
                }
            }

            return i;
        }

        public string SaveTimeSheet()
        {
            var saveField = TheBrowser.Frame("containerFrame").Div(Find.ByName("b$_item_save"));
            saveField.Click();

            var errorsField = TheBrowser.Frame("containerFrame").Table(Find.ById("_errorBlock"));
            if (errorsField.Exists)
            {
                return "Fel";
            }
            return "Ok";
        }

        public void SalarySuggestion()
        {
            var reports = TheBrowser.Frame("_menuFrame").Link(Find.ByText("Rapporter"));
            reports.Click();

            var plusLink = TheBrowser.Frame("_menuFrame").Image(Find.BySrc("https://economy.waygroup.se/agresso/System/Images/Plus.gif"));
            while (plusLink.Exists)
            {
                plusLink.Click();
                plusLink = TheBrowser.Frame("_menuFrame").Image(Find.BySrc("https://economy.waygroup.se/agresso/System/Images/Plus.gif"));
            }

            var salarySuggestion = TheBrowser.Frame("_menuFrame").Link(Find.ByText("Löneförslag / person (self service)"));
            salarySuggestion.Click();

            var ie2 = Browser.AttachTo<IE>(Find.ByUrl(new StringContainsAndCaseInsensitiveComparer("https://economy.waygroup.se/agresso/Default.aspx?type=topgen&menu_id=REP26&template_id=183")));
            ie2.ShowWindow(NativeMethods.WindowShowStyle.ShowMaximized);
            var search = ie2.Frame("containerFrame").Button("b_g1s3_ctl08_findBRT");
            search.Click();
        }

        public void SalarySpec()
        {
            var info = TheBrowser.Frame("_menuFrame").Link(Find.ByText("Personalinfo"));
            info.Click();

            var plusLink = TheBrowser.Frame("_menuFrame").Image(Find.BySrc("https://economy.waygroup.se/agresso/System/Images/Plus.gif"));
            while (plusLink.Exists)
            {
                plusLink.Click();
                plusLink = TheBrowser.Frame("_menuFrame").Image(Find.BySrc("https://economy.waygroup.se/agresso/System/Images/Plus.gif"));
            }

            var salary = TheBrowser.Frame("_menuFrame").Link(Find.ByText("Lönespecifikation"));
            salary.Click();
        }

        public void Logout()
        {
            try
            {
                var logoutField = TheBrowser.Frame("_menuFrame").Div(Find.ByTitle("Avsluta aktuell session"));
                if (logoutField.Exists)
                {
                    logoutField.Click();
                }

                TheBrowser.Close();
                //TheBrowser = null;
            }
            catch { }

        }

        public string GetSettingsString()
        {
            var userName = Settings["Login.UserName"];
            var client = Settings["Login.Client"];
            var url = Settings["Agresso.Url"];

            return string.Format("Name: {0} @ {1}{2}{3}{4}", userName, client, Environment.NewLine, url, Environment.NewLine);
        }

        public void GotoTimeRegistration1(string[] reg1) 
        {
            string timeCodeId = reg1[0];
            string projectId = reg1[1];
            string activityId = reg1[2];
            string description = reg1[3];
            string roleId = reg1[4];
            double hours1 = double.Parse(reg1[5]);
            double hours2 = double.Parse(reg1[6]);
            double hours3 = double.Parse(reg1[7]);
            double hours4 = double.Parse(reg1[8]);
            double hours5 = double.Parse(reg1[9]);
            double hours6 = double.Parse(reg1[10]);
            double hours7 = double.Parse(reg1[11]);

            int i = InsertNewLine();
            RegisterProjectDay(i, timeCodeId, projectId, activityId, description, roleId, hours1, hours2, hours3, hours4, hours5, hours6, hours7);
        }

        private void GotoPeriod(int offset, int periodPart)
        {
            var periodField = TheBrowser.Frame("containerFrame").TextField(Find.ById("b_s71_s2_s84_l2s84_ctl00_reg_period_i"));
            string periodId = periodField.Text;
            string previousPeriodId;

            if (offset == 666)
            {
                string year = DateTime.Today.ToString("yy");
                int weekOfYear = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Today,
                                                                                   CalendarWeekRule.FirstFourDayWeek,
                                                                                   DayOfWeek.Monday);

                previousPeriodId = string.Format("2{0}{1}{2}", year, weekOfYear, periodPart);
            }
            else
            {
                string year = periodId.Substring(1, 2);
                int weekOfYear = int.Parse(periodId.Substring(3, 2));

                weekOfYear += offset;

                previousPeriodId = string.Format("2{0}{1}{2}", year, weekOfYear, periodPart);
            }

            periodField.TypeText(previousPeriodId);
        }

        public void GotoPreviousPeriod()
        {
            string currentPeriod = GetCurrentPeriodId();
            if (currentPeriod.EndsWith("_1"))
            {
                GotoPeriod(-1, 1);
            }
            else if (currentPeriod.EndsWith("_2"))
            {
                GotoPeriod(0, 1);
            }
            else
            {
                GotoPeriod(-1, 1);
            }
        }

        public void GotoNextPeriod()
        {
            string currentPeriod = GetCurrentPeriodId();
            if (currentPeriod.EndsWith("_1"))
            {
                GotoPeriod(0, 2);
            }
            else if (currentPeriod.EndsWith("_2"))
            {
                GotoPeriod(1, 1);
            }
            else
            {
                GotoPeriod(1, 1);
            }
        }

        public void GotoThisPeriod()
        {
            GotoPeriod(666, 1);
        }

        private string GetCurrentPeriodId()
        {
            var currentPeriodField = TheBrowser.Frame("containerFrame").Div(Find.ById("b_s71_s2_s84_l2s84_ctl00_reg_period_m"));
            string periodId = currentPeriodField.Text;
            return periodId;
        }

        public void Quit()
        {
            try
            {
                _ie7.Close();
            }
            catch
            {}
        }

        public void GotoExpenses()
        {
            var timeAndExpenses = TheBrowser.Frame("_menuFrame").Link(Find.ByText("Tid och utlägg"));
            timeAndExpenses.Click();

            var plusLink = TheBrowser.Frame("_menuFrame").Image(Find.BySrc("https://economy.waygroup.se/agresso/System/Images/Plus.gif"));
            while (plusLink.Exists)
            {
                plusLink.Click();
                plusLink = TheBrowser.Frame("_menuFrame").Image(Find.BySrc("https://economy.waygroup.se/agresso/System/Images/Plus.gif"));
            }

            var daily = TheBrowser.Frame("_menuFrame").Link(Find.ByText("Reseräkning"));
            daily.Click();


            var purposeField = TheBrowser.Frame("containerFrame").TextField(Find.ById("b_s5_l1s5_ctl00_ext_inv_ref_i"));
            purposeField.TypeText(DateTime.Today.ToString("MMMM yyyy"));

            var commentField = TheBrowser.Frame("containerFrame").TextField(Find.ById("b_s5_l1s5_ctl00_comment_i"));
            commentField.TypeText("Resor till Saxo Bank och massage");

            var typesField = TheBrowser.Frame("containerFrame").SelectList(Find.ById("b_s5_l1s5_ctl00_travel_type_i"));
            typesField.Select("Enbart utlägg");

            var nextField = TheBrowser.Frame("containerFrame").Button(Find.ById("b__pageButtons__wizNext"));
            nextField.Click();
        }

        private int InsertNewExpenseLine()
        {
            var addRowField = TheBrowser.Frame("containerFrame").Button(Find.ById("b_g3s14__buttons__newButton"));
            addRowField.Click();

            int i = -1;
            for (int rowNo = 0; rowNo < 10; rowNo++)
            {
                var descriptionField =
                    TheBrowser.Frame("containerFrame").SelectList(
                        Find.ById(string.Format("b_s15_l3s15_ctl0{0}_expense_type_i", rowNo)));
                
                if (descriptionField.Exists)
                {
                    i = rowNo;
                    break;
                }
            }

            return i;
        }

        public void Expenses1()
        {
            // miles

            int rowNo = InsertNewExpenseLine();

            var expenseTypeField = TheBrowser.Frame("containerFrame").SelectList(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_expense_type_i", rowNo)));
            expenseTypeField.Select("Milersättning");

            var descriptionField = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_description_i", rowNo)));
            descriptionField.TypeText("Milersättning Lund <-> Hellerup 10 x 19 mil");

            var milCountField = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_value_1_i", rowNo)));
            milCountField.TypeText("190");

            var projectField = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_s53_l15s53_ctl0{0}_dim_2_i", rowNo)));
            projectField.TypeText("10167");
        }
        
        public void Expenses2()
        {
            // broBizz

            int rowNo = InsertNewExpenseLine();

            var expenseType3Field = TheBrowser.Frame("containerFrame").SelectList(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_expense_type_i", rowNo)));
            expenseType3Field.Select("Resor");

            var description3Field = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_description_i", rowNo)));
            description3Field.TypeText("BroBizz Lund <-> Hellerup x10");

            var amount3Field = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_amount_i", rowNo)));
            amount3Field.TypeText("700");

            var date3 = DateTime.Today.AddDays(-10);
            var date3Field = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_date_from_i", rowNo)));
            date3Field.TypeText(date3.ToString("yyyy-MM-dd"));

            var project3Field = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_s53_l15s53_ctl0{0}_dim_2_i", rowNo)));
            project3Field.TypeText("10167");

            var taxt3Field = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_s53_l15s53_ctl0{0}_tax_code_i", rowNo)));
            taxt3Field.TypeText("I25");
        }

        public void Expenses3()
        {
            // Massage

            int rowNo = InsertNewExpenseLine();

            var expenseType2Field = TheBrowser.Frame("containerFrame").SelectList(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_expense_type_i", rowNo)));
            expenseType2Field.Select("Friskvård (massage, naprapat)");

            var amount2Field = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_amount_i", rowNo)));
            amount2Field.TypeText("500");

            var date2 = DateTime.Today.AddDays(-11);
            var date2Field = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_date_from_i", rowNo)));
            date2Field.TypeText(date2.ToString("yyyy-MM-dd"));

            var description2Field = TheBrowser.Frame("containerFrame").TextField(Find.ById(string.Format("b_s15_l3s15_ctl0{0}_description_i", rowNo)));
            description2Field.TypeText("Massage " + date2.ToString("MMMM"));
        }

        public string SaveExpenses()
        {
            var next2Field = TheBrowser.Frame("containerFrame").Button(Find.ById("b__pageButtons__wizNext"));
            next2Field.Click();

            var saveField = TheBrowser.Frame("containerFrame").Div(Find.ByName("b$_item_save"));
            saveField.Click();

            var infoField = TheBrowser.Frame("containerFrame").Table(Find.ByClass("InfoBlock"));
            string info = infoField.Text;
            return info;
        }

        public string Version()
        {
            var time = TheBrowser.Frame("_menuFrame").Link(Find.ByText("Agresso Business World"));
            time.Click();

            var sysInfo = TheBrowser.Frame("_menuFrame").TableCell(Find.ByText("Version"));
            Element version = sysInfo.NextSibling;
            return version.Text;
        }
    }
}
