﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestProject1
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCodeAttribute("Coded UITest Builder", "10.0.21006.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WpfListItem classLibrary1EFPersoListItem = this.MainWindowWindow.ListView1List.ClassLibrary1EFPersoListItem;
            WpfTitleBar mainWindowTitleBar = this.MainWindowWindow.MainWindowTitleBar;
            WinMenuItem closeMenuItem = this.MainWindowWindow1.SystemMenuBar.SystemMenuItem.CloseMenuItem;
            #endregion

            // Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
            ApplicationUnderTest mainWindowWindow = ApplicationUnderTest.Launch(this.RecordedMethod1Params.MainWindowWindowExePath, this.RecordedMethod1Params.MainWindowWindowAlternateExePath);

            // Double-Click 'ClassLibrary1.EF.Person' list item
            Mouse.DoubleClick(classLibrary1EFPersoListItem, new Point(47, 10));

            // Type '{Tab}' in 'ClassLibrary1.EF.Person' list item
            Keyboard.SendKeys(classLibrary1EFPersoListItem, this.RecordedMethod1Params.ClassLibrary1EFPersoListItemSendKeys, ModifierKeys.None);

            // Right-Click 'MainWindow' title bar
            Mouse.Click(mainWindowTitleBar, MouseButtons.Right, ModifierKeys.None, new Point(364, 13));

            // Click 'System' -> 'Close' menu item
            Mouse.Click(closeMenuItem, new Point(48, 4));
        }
        
        /// <summary>
        /// RecordedMethod2 - Use 'RecordedMethod2Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod2()
        {
            #region Variable Declarations
            WpfButton den18november2009Button = this.MainWindowWindow.Calendar1Calendar.Den18november2009Button;
            WpfButton closeButton = this.MainWindowWindow.MainWindowTitleBar.CloseButton;
            #endregion

            // Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
            ApplicationUnderTest mainWindowWindow = ApplicationUnderTest.Launch(this.RecordedMethod2Params.MainWindowWindowExePath, this.RecordedMethod2Params.MainWindowWindowAlternateExePath);

            // Click 'den 18 november 2009' button
            Mouse.Click(den18november2009Button, new Point(9, 10));

            // Click 'Close' button
            Mouse.Click(closeButton, new Point(12, 8));
        }
        
        /// <summary>
        /// AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            WpfButton den8november2009Button = this.MainWindowWindow.Calendar1Calendar.Den8november2009Button;
            #endregion

            // Verify that 'den 8 november 2009' button's property 'DisplayText' equals 'den 8 november 2009'
            Assert.AreEqual(this.AssertMethod1ExpectedValues.Den8november2009ButtonDisplayText, den8november2009Button.DisplayText);
        }
        
        /// <summary>
        /// AssertMethod2 - Use 'AssertMethod2ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod2()
        {
            #region Variable Declarations
            WpfEdit pART_TextBoxEdit = this.MainWindowWindow.DatePicker1Custom.PART_TextBoxEdit;
            #endregion

            // Verify that 'PART_TextBox' text box's property 'Text' equals '2009-11-18'
            Assert.AreEqual(this.AssertMethod2ExpectedValues.PART_TextBoxEditText, pART_TextBoxEdit.Text);
        }
        
        /// <summary>
        /// RecordedMethod3
        /// </summary>
        public void RecordedMethod3()
        {
            #region Variable Declarations
            WpfButton den10december2009Button = this.MainWindowWindow.Calendar1Calendar.Den10december2009Button;
            WpfButton den18december2009Button = this.MainWindowWindow.Calendar1Calendar.Den18december2009Button;
            #endregion

            // Click 'den 10 december 2009' button
            Mouse.Click(den10december2009Button, new Point(16, 6));

            // Click 'den 18 december 2009' button
            Mouse.Click(den18december2009Button, new Point(12, 4));
        }
        
        /// <summary>
        /// AssertMethod3 - Use 'AssertMethod3ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod3()
        {
            #region Variable Declarations
            WpfEdit pART_TextBoxEdit = this.MainWindowWindow.DatePicker1Custom.PART_TextBoxEdit;
            #endregion

            // Verify that 'PART_TextBox' text box's property 'Text' equals '2009-12-18'
            Assert.AreEqual(this.AssertMethod3ExpectedValues.PART_TextBoxEditText, pART_TextBoxEdit.Text);
        }
        
        /// <summary>
        /// RecordedMethod4 - Use 'RecordedMethod4Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod4()
        {
            #region Variable Declarations
            WpfButton den18december2009Button = this.MainWindowWindow.Calendar1Calendar.Den18december2009Button;
            #endregion

            // Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
            ApplicationUnderTest mainWindowWindow = ApplicationUnderTest.Launch(this.RecordedMethod4Params.MainWindowWindowExePath, this.RecordedMethod4Params.MainWindowWindowAlternateExePath);

            // Click 'den 18 december 2009' button
            Mouse.Click(den18december2009Button, new Point(10, 2));
        }
        
        /// <summary>
        /// AssertMethod4 - Use 'AssertMethod4ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod4()
        {
            #region Variable Declarations
            WpfEdit pART_TextBoxEdit = this.MainWindowWindow.DatePicker1Custom.PART_TextBoxEdit;
            #endregion

            // Verify that 'PART_TextBox' text box's property 'Text' equals '2009-12-18'
            Assert.AreEqual(this.AssertMethod4ExpectedValues.PART_TextBoxEditText, pART_TextBoxEdit.Text);
        }
        
        /// <summary>
        /// RecordedMethod5 - Use 'RecordedMethod5Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod5()
        {
            #region Variable Declarations
            WpfButton den9december2009Button = this.MainWindowWindow.Calendar1Calendar.Den9december2009Button;
            WpfButton den10december2009Button = this.MainWindowWindow.Calendar1Calendar.Den10december2009Button;
            WpfButton den11december2009Button = this.MainWindowWindow.Calendar1Calendar.Den11december2009Button;
            #endregion

            // Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
            ApplicationUnderTest mainWindowWindow = ApplicationUnderTest.Launch(this.RecordedMethod5Params.MainWindowWindowExePath, this.RecordedMethod5Params.MainWindowWindowAlternateExePath);

            // Click 'den 9 december 2009' button
            Mouse.Click(den9december2009Button, new Point(8, 10));

            // Click 'den 10 december 2009' button
            Mouse.Click(den10december2009Button, new Point(15, 9));

            // Click 'den 11 december 2009' button
            Mouse.Click(den11december2009Button, new Point(8, 8));
        }
        
        /// <summary>
        /// RecordedMethod6 - Use 'RecordedMethod6Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod6()
        {
            #region Variable Declarations
            WpfButton den10december2009Button = this.MainWindowWindow.Calendar1Calendar.Den10december2009Button;
            WpfButton den11december2009Button = this.MainWindowWindow.Calendar1Calendar.Den11december2009Button;
            WpfButton closeButton = this.MainWindowWindow.MainWindowTitleBar.CloseButton;
            #endregion

            // Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
            ApplicationUnderTest mainWindowWindow = ApplicationUnderTest.Launch(this.RecordedMethod6Params.MainWindowWindowExePath, this.RecordedMethod6Params.MainWindowWindowAlternateExePath);

            // Click 'den 10 december 2009' button
            Mouse.Click(den10december2009Button, new Point(15, 14));

            // Click 'den 11 december 2009' button
            Mouse.Click(den11december2009Button, new Point(15, 4));

            // Click 'Close' button
            Mouse.Click(closeButton, new Point(21, 10));
        }
        
        /// <summary>
        /// AssertMethod5 - Use 'AssertMethod5ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod5()
        {
            #region Variable Declarations
            WpfEdit pART_TextBoxEdit = this.MainWindowWindow.DatePicker1Custom.PART_TextBoxEdit;
            #endregion

            // Verify that 'PART_TextBox' text box's property 'Text' equals '2009-12-11'
            Assert.AreEqual(this.AssertMethod5ExpectedValues.PART_TextBoxEditText, pART_TextBoxEdit.Text);
        }
        
        /// <summary>
        /// RecordedMethod7 - Use 'RecordedMethod7Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod7()
        {
            #region Variable Declarations
            WpfButton den10december2009Button = this.MainWindowWindow.Calendar1Calendar.Den10december2009Button;
            WpfButton den11december2009Button = this.MainWindowWindow.Calendar1Calendar.Den11december2009Button;
            #endregion

            // Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
            ApplicationUnderTest mainWindowWindow = ApplicationUnderTest.Launch(this.RecordedMethod7Params.MainWindowWindowExePath, this.RecordedMethod7Params.MainWindowWindowAlternateExePath);

            // Click 'den 10 december 2009' button
            Mouse.Click(den10december2009Button, new Point(4, 8));

            // Click 'den 11 december 2009' button
            Mouse.Click(den11december2009Button, new Point(6, 6));
        }
        
        /// <summary>
        /// AssertMethod6 - Use 'AssertMethod6ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod6()
        {
            #region Variable Declarations
            WpfEdit pART_TextBoxEdit = this.MainWindowWindow.DatePicker1Custom.PART_TextBoxEdit;
            #endregion

            // Verify that 'PART_TextBox' text box's property 'Text' equals '2009-12-11'
            Assert.AreEqual(this.AssertMethod6ExpectedValues.PART_TextBoxEditText, pART_TextBoxEdit.Text);
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public virtual RecordedMethod2Params RecordedMethod2Params
        {
            get
            {
                if ((this.mRecordedMethod2Params == null))
                {
                    this.mRecordedMethod2Params = new RecordedMethod2Params();
                }
                return this.mRecordedMethod2Params;
            }
        }
        
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public virtual AssertMethod2ExpectedValues AssertMethod2ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod2ExpectedValues == null))
                {
                    this.mAssertMethod2ExpectedValues = new AssertMethod2ExpectedValues();
                }
                return this.mAssertMethod2ExpectedValues;
            }
        }
        
        public virtual AssertMethod3ExpectedValues AssertMethod3ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod3ExpectedValues == null))
                {
                    this.mAssertMethod3ExpectedValues = new AssertMethod3ExpectedValues();
                }
                return this.mAssertMethod3ExpectedValues;
            }
        }
        
        public virtual RecordedMethod4Params RecordedMethod4Params
        {
            get
            {
                if ((this.mRecordedMethod4Params == null))
                {
                    this.mRecordedMethod4Params = new RecordedMethod4Params();
                }
                return this.mRecordedMethod4Params;
            }
        }
        
        public virtual AssertMethod4ExpectedValues AssertMethod4ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod4ExpectedValues == null))
                {
                    this.mAssertMethod4ExpectedValues = new AssertMethod4ExpectedValues();
                }
                return this.mAssertMethod4ExpectedValues;
            }
        }
        
        public virtual RecordedMethod5Params RecordedMethod5Params
        {
            get
            {
                if ((this.mRecordedMethod5Params == null))
                {
                    this.mRecordedMethod5Params = new RecordedMethod5Params();
                }
                return this.mRecordedMethod5Params;
            }
        }
        
        public virtual RecordedMethod6Params RecordedMethod6Params
        {
            get
            {
                if ((this.mRecordedMethod6Params == null))
                {
                    this.mRecordedMethod6Params = new RecordedMethod6Params();
                }
                return this.mRecordedMethod6Params;
            }
        }
        
        public virtual AssertMethod5ExpectedValues AssertMethod5ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod5ExpectedValues == null))
                {
                    this.mAssertMethod5ExpectedValues = new AssertMethod5ExpectedValues();
                }
                return this.mAssertMethod5ExpectedValues;
            }
        }
        
        public virtual RecordedMethod7Params RecordedMethod7Params
        {
            get
            {
                if ((this.mRecordedMethod7Params == null))
                {
                    this.mRecordedMethod7Params = new RecordedMethod7Params();
                }
                return this.mRecordedMethod7Params;
            }
        }
        
        public virtual AssertMethod6ExpectedValues AssertMethod6ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod6ExpectedValues == null))
                {
                    this.mAssertMethod6ExpectedValues = new AssertMethod6ExpectedValues();
                }
                return this.mAssertMethod6ExpectedValues;
            }
        }
        
        public MainWindowWindow MainWindowWindow
        {
            get
            {
                if ((this.mMainWindowWindow == null))
                {
                    this.mMainWindowWindow = new MainWindowWindow();
                }
                return this.mMainWindowWindow;
            }
        }
        
        public MainWindowWindow1 MainWindowWindow1
        {
            get
            {
                if ((this.mMainWindowWindow1 == null))
                {
                    this.mMainWindowWindow1 = new MainWindowWindow1();
                }
                return this.mMainWindowWindow1;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private RecordedMethod2Params mRecordedMethod2Params;
        
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private AssertMethod2ExpectedValues mAssertMethod2ExpectedValues;
        
        private AssertMethod3ExpectedValues mAssertMethod3ExpectedValues;
        
        private RecordedMethod4Params mRecordedMethod4Params;
        
        private AssertMethod4ExpectedValues mAssertMethod4ExpectedValues;
        
        private RecordedMethod5Params mRecordedMethod5Params;
        
        private RecordedMethod6Params mRecordedMethod6Params;
        
        private AssertMethod5ExpectedValues mAssertMethod5ExpectedValues;
        
        private RecordedMethod7Params mRecordedMethod7Params;
        
        private AssertMethod6ExpectedValues mAssertMethod6ExpectedValues;
        
        private MainWindowWindow mMainWindowWindow;
        
        private MainWindowWindow1 mMainWindowWindow1;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowAlternateExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        
        /// <summary>
        /// Type '{Tab}' in 'ClassLibrary1.EF.Person' list item
        /// </summary>
        public string ClassLibrary1EFPersoListItemSendKeys = "{Tab}";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod2'
    /// </summary>
    public class RecordedMethod2Params
    {
        
        #region Fields
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowAlternateExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod1'
    /// </summary>
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that 'den 8 november 2009' button's property 'DisplayText' equals 'den 8 november 2009'
        /// </summary>
        public string Den8november2009ButtonDisplayText = "den 8 november 2009";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod2'
    /// </summary>
    public class AssertMethod2ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that 'PART_TextBox' text box's property 'Text' equals '2009-11-18'
        /// </summary>
        public string PART_TextBoxEditText = "2009-11-18";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod3'
    /// </summary>
    public class AssertMethod3ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that 'PART_TextBox' text box's property 'Text' equals '2009-12-18'
        /// </summary>
        public string PART_TextBoxEditText = "2009-12-18";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod4'
    /// </summary>
    public class RecordedMethod4Params
    {
        
        #region Fields
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowAlternateExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod4'
    /// </summary>
    public class AssertMethod4ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that 'PART_TextBox' text box's property 'Text' equals '2009-12-18'
        /// </summary>
        public string PART_TextBoxEditText = "2009-12-18";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod5'
    /// </summary>
    public class RecordedMethod5Params
    {
        
        #region Fields
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowAlternateExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod6'
    /// </summary>
    public class RecordedMethod6Params
    {
        
        #region Fields
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowAlternateExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod5'
    /// </summary>
    public class AssertMethod5ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that 'PART_TextBox' text box's property 'Text' equals '2009-12-11'
        /// </summary>
        public string PART_TextBoxEditText = "2009-12-11";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod7'
    /// </summary>
    public class RecordedMethod7Params
    {
        
        #region Fields
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        
        /// <summary>
        /// Launch 'C:\Projects\MbUnitDemo\Vs2010Seminar\src\DataFlow\WpfApplication1\bin\Debug\WpfApplication1.exe'
        /// </summary>
        public string MainWindowWindowAlternateExePath = "C:\\Projects\\MbUnitDemo\\Vs2010Seminar\\src\\DataFlow\\WpfApplication1\\bin\\Debug\\WpfAp" +
            "plication1.exe";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod6'
    /// </summary>
    public class AssertMethod6ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that 'PART_TextBox' text box's property 'Text' equals '2009-12-11'
        /// </summary>
        public string PART_TextBoxEditText = "2009-12-11";
        #endregion
    }
    
    public class MainWindowWindow : WpfWindow
    {
        
        public MainWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfProperties.Window.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfProperties.Window.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public ListView1List ListView1List
        {
            get
            {
                if ((this.mListView1List == null))
                {
                    this.mListView1List = new ListView1List(this);
                }
                return this.mListView1List;
            }
        }
        
        public MainWindowTitleBar MainWindowTitleBar
        {
            get
            {
                if ((this.mMainWindowTitleBar == null))
                {
                    this.mMainWindowTitleBar = new MainWindowTitleBar(this);
                }
                return this.mMainWindowTitleBar;
            }
        }
        
        public Calendar1Calendar Calendar1Calendar
        {
            get
            {
                if ((this.mCalendar1Calendar == null))
                {
                    this.mCalendar1Calendar = new Calendar1Calendar(this);
                }
                return this.mCalendar1Calendar;
            }
        }
        
        public DatePicker1Custom DatePicker1Custom
        {
            get
            {
                if ((this.mDatePicker1Custom == null))
                {
                    this.mDatePicker1Custom = new DatePicker1Custom(this);
                }
                return this.mDatePicker1Custom;
            }
        }
        #endregion
        
        #region Fields
        private ListView1List mListView1List;
        
        private MainWindowTitleBar mMainWindowTitleBar;
        
        private Calendar1Calendar mCalendar1Calendar;
        
        private DatePicker1Custom mDatePicker1Custom;
        #endregion
    }
    
    public class ListView1List : WpfList
    {
        
        public ListView1List(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfProperties.List.AutomationId] = "listView1";
            #endregion
        }
        
        #region Properties
        public WpfListItem ClassLibrary1EFPersoListItem
        {
            get
            {
                if ((this.mClassLibrary1EFPersoListItem == null))
                {
                    this.mClassLibrary1EFPersoListItem = new WpfListItem(this);
                    #region Search Criteria
                    this.mClassLibrary1EFPersoListItem.SearchProperties[WpfProperties.ListItem.Name] = "ClassLibrary1.EF.Person";
                    #endregion
                }
                return this.mClassLibrary1EFPersoListItem;
            }
        }
        #endregion
        
        #region Fields
        private WpfListItem mClassLibrary1EFPersoListItem;
        #endregion
    }
    
    public class MainWindowTitleBar : WpfTitleBar
    {
        
        public MainWindowTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfProperties.TitleBar.AutomationId] = "TitleBar";
            #endregion
        }
        
        #region Properties
        public WpfButton CloseButton
        {
            get
            {
                if ((this.mCloseButton == null))
                {
                    this.mCloseButton = new WpfButton(this);
                    #region Search Criteria
                    this.mCloseButton.SearchProperties[WpfProperties.Button.AutomationId] = "Close";
                    #endregion
                }
                return this.mCloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mCloseButton;
        #endregion
    }
    
    public class Calendar1Calendar : WpfCalendar
    {
        
        public Calendar1Calendar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["AutomationId"] = "calendar1";
            #endregion
        }
        
        #region Properties
        public WpfButton Den18november2009Button
        {
            get
            {
                if ((this.mDen18november2009Button == null))
                {
                    this.mDen18november2009Button = new WpfButton(this);
                    #region Search Criteria
                    this.mDen18november2009Button.SearchProperties[WpfProperties.Button.Name] = "den 18 november 2009";
                    #endregion
                }
                return this.mDen18november2009Button;
            }
        }
        
        public WpfButton Den8november2009Button
        {
            get
            {
                if ((this.mDen8november2009Button == null))
                {
                    this.mDen8november2009Button = new WpfButton(this);
                    #region Search Criteria
                    this.mDen8november2009Button.SearchProperties[WpfProperties.Button.Name] = "den 8 november 2009";
                    #endregion
                }
                return this.mDen8november2009Button;
            }
        }
        
        public WpfButton Den10december2009Button
        {
            get
            {
                if ((this.mDen10december2009Button == null))
                {
                    this.mDen10december2009Button = new WpfButton(this);
                    #region Search Criteria
                    this.mDen10december2009Button.SearchProperties[WpfProperties.Button.Name] = "den 10 december 2009";
                    #endregion
                }
                return this.mDen10december2009Button;
            }
        }
        
        public WpfButton Den18december2009Button
        {
            get
            {
                if ((this.mDen18december2009Button == null))
                {
                    this.mDen18december2009Button = new WpfButton(this);
                    #region Search Criteria
                    this.mDen18december2009Button.SearchProperties[WpfProperties.Button.Name] = "den 18 december 2009";
                    #endregion
                }
                return this.mDen18december2009Button;
            }
        }
        
        public WpfButton Den9december2009Button
        {
            get
            {
                if ((this.mDen9december2009Button == null))
                {
                    this.mDen9december2009Button = new WpfButton(this);
                    #region Search Criteria
                    this.mDen9december2009Button.SearchProperties[WpfProperties.Button.Name] = "den 9 december 2009";
                    #endregion
                }
                return this.mDen9december2009Button;
            }
        }
        
        public WpfButton Den11december2009Button
        {
            get
            {
                if ((this.mDen11december2009Button == null))
                {
                    this.mDen11december2009Button = new WpfButton(this);
                    #region Search Criteria
                    this.mDen11december2009Button.SearchProperties[WpfProperties.Button.Name] = "den 11 december 2009";
                    #endregion
                }
                return this.mDen11december2009Button;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mDen18november2009Button;
        
        private WpfButton mDen8november2009Button;
        
        private WpfButton mDen10december2009Button;
        
        private WpfButton mDen18december2009Button;
        
        private WpfButton mDen9december2009Button;
        
        private WpfButton mDen11december2009Button;
        #endregion
    }
    
    public class DatePicker1Custom : WpfCustom
    {
        
        public DatePicker1Custom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControlProperties.Common.ClassName] = "Uia.DatePicker";
            this.SearchProperties["AutomationId"] = "datePicker1";
            #endregion
        }
        
        #region Properties
        public WpfEdit PART_TextBoxEdit
        {
            get
            {
                if ((this.mPART_TextBoxEdit == null))
                {
                    this.mPART_TextBoxEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mPART_TextBoxEdit.SearchProperties[WpfProperties.Edit.AutomationId] = "PART_TextBox";
                    #endregion
                }
                return this.mPART_TextBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mPART_TextBoxEdit;
        #endregion
    }
    
    public class MainWindowWindow1 : WinWindow
    {
        
        public MainWindowWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinProperties.Window.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WinProperties.Window.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public SystemMenuBar SystemMenuBar
        {
            get
            {
                if ((this.mSystemMenuBar == null))
                {
                    this.mSystemMenuBar = new SystemMenuBar(this);
                }
                return this.mSystemMenuBar;
            }
        }
        #endregion
        
        #region Fields
        private SystemMenuBar mSystemMenuBar;
        #endregion
    }
    
    public class SystemMenuBar : WinMenuBar
    {
        
        public SystemMenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinProperties.Menu.Name] = "System";
            #endregion
        }
        
        #region Properties
        public SystemMenuItem SystemMenuItem
        {
            get
            {
                if ((this.mSystemMenuItem == null))
                {
                    this.mSystemMenuItem = new SystemMenuItem(this);
                }
                return this.mSystemMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private SystemMenuItem mSystemMenuItem;
        #endregion
    }
    
    public class SystemMenuItem : WinMenuItem
    {
        
        public SystemMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinProperties.MenuItem.Name] = "System";
            #endregion
        }
        
        #region Properties
        public WinMenuItem CloseMenuItem
        {
            get
            {
                if ((this.mCloseMenuItem == null))
                {
                    this.mCloseMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mCloseMenuItem.SearchProperties[WinProperties.MenuItem.Name] = "Close";
                    this.mCloseMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    #endregion
                }
                return this.mCloseMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mCloseMenuItem;
        #endregion
    }
}
