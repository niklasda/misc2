using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ProxyMocker.Tests
{
   
    public class Msdn
    {
        public Msdn ()
	{

	
        // Creating a dynamic assembly requires an AssemblyName
        // object, and the current application domain.
        //
        AssemblyName asmName = 
            new AssemblyName("DemoMethodBuilder1");
        AppDomain domain = AppDomain.CurrentDomain;
        AssemblyBuilder demoAssembly = 
            domain.DefineDynamicAssembly(
                asmName, 
                AssemblyBuilderAccess.RunAndSave
            );

        // Define the module that contains the code. For an 
        // assembly with one module, the module name is the 
        // assembly name plus a file extension.
        ModuleBuilder demoModule = 
            demoAssembly.DefineDynamicModule(
                asmName.Name, 
                asmName.Name + ".dll"
            );
      
        TypeBuilder demoType = demoModule.DefineType(
            "DemoType", 
            TypeAttributes.Public 
        );

        // Define a Shared, Public method with standard calling
        // conventions. Do not specify the parameter types or the
        // return type, because type parameters will be used for 
        // those types, and the type parameters have not been
        // defined yet.
        MethodBuilder demoMethod = demoType.DefineMethod(
            "DemoMethod", 
            MethodAttributes.Public //| MethodAttributes.Static
     
        );

        // Defining generic parameters for the method makes it a
        // generic method. By convention, type parameters are 
        // single alphabetic characters. T and U are used here.
        //
        string[] typeParamNames = {"T"};
        GenericTypeParameterBuilder[] typeParameters = 
            demoMethod.DefineGenericParameters(typeParamNames);

        // The second type parameter is constrained to be a 
        // reference type.
        //typeParameters[1].SetGenericParameterAttributes( 
        //    GenericParameterAttributes.ReferenceTypeConstraint);

        // Use the IsGenericMethod property to find out if a
        // dynamic method is generic, and IsGenericMethodDefinition
        // to find out if it defines a generic method.
        Console.WriteLine("Is DemoMethod generic? {0}", 
            demoMethod.IsGenericMethod);
        Console.WriteLine("Is DemoMethod a generic method definition? {0}", 
            demoMethod.IsGenericMethodDefinition);

        // Set parameter types for the method. The method takes
        // one parameter, and its type is specified by the first
        // type parameter, T.
   //     Type[] parms = {typeParameters[0]};
   //     demoMethod.SetParameters(parms);

        // Set the return type for the method. The return type is
        // specified by the second type parameter, U.
        demoMethod.SetReturnType(typeof(int ));

        // Generate a code body for the method. The method doesn't
        // do anything except return null.
        //
        ILGenerator ilgen = demoMethod.GetILGenerator();
        ilgen.Emit(OpCodes.Ldnull);
        ilgen.Emit(OpCodes.Ret);

        // Complete the type.
        Type dt = demoType.CreateType();

        // To bind types to a dynamic generic method, you must 
        // first call the GetMethod method on the completed type.
        // You can then define an array of types, and bind them
        // to the method.
        MethodInfo m = dt.GetMethod("DemoMethod");
        Type[] typeArgs = {typeof(string)};
        MethodInfo bound = m.MakeGenericMethod(typeArgs);
        // Display a string representing the bound method.
        Console.WriteLine(bound);

        // Save the assembly, so it can be examined with Ildasm.exe.
        demoAssembly.Save(asmName.Name + ".dll");

        object o = Activator.CreateInstance(dt);
            
    }
}
}
