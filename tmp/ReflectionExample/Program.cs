// Decompiled with JetBrains decompiler
// Type: ReflectionExample.Program
// Assembly: ReflectionExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 55589AB4-F7C6-445B-9741-FEF5A642B813
// Assembly location: C:\Users\emilp\source\repos\Dzien09-10\ReflectionExample\bin\Debug\ReflectionExample.exe

using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionExample
{
  internal class Program
  {
    private static async Task Main(string[] args)
    {
      ReflectionTest.fieldA = 1;
      ReflectionTest.fieldB = 1.23;
      ReflectionTest.fieldC = "AAAA";
      ReflectionTest.fieldD = true;
      string code = "var a=9; if (a>=9) {return 1;} else {return -10;}";
      int result = await CSharpScript.EvaluateAsync<int>(code);
      Console.WriteLine(result);
      Assembly assembly = Assembly.LoadFrom("ExternalLibrary.dll");
      foreach (Type type in assembly.ExportedTypes)
      {
        Console.WriteLine("========================");
        Console.WriteLine(type.FullName);
        ConstructorInfo[] constructorInfoArray = type.GetConstructors();
        for (int index1 = 0; index1 < constructorInfoArray.Length; ++index1)
        {
          ConstructorInfo ctr = constructorInfoArray[index1];
          Console.WriteLine("Konstruktor: " + ctr.Name);
          ParameterInfo[] parameterInfoArray = ctr.GetParameters();
          for (int index2 = 0; index2 < parameterInfoArray.Length; ++index2)
          {
            ParameterInfo ctrParam = parameterInfoArray[index2];
            Console.WriteLine(string.Format("{0} : {1}", (object) ctrParam.Name, (object) ctrParam.ParameterType));
            ctrParam = (ParameterInfo) null;
          }
          parameterInfoArray = (ParameterInfo[]) null;
          ctr = (ConstructorInfo) null;
        }
        constructorInfoArray = (ConstructorInfo[]) null;
        Console.WriteLine("====================");
        Console.WriteLine("Properties");
        PropertyInfo[] propertyInfoArray = type.GetProperties();
        for (int index = 0; index < propertyInfoArray.Length; ++index)
        {
          PropertyInfo prop = propertyInfoArray[index];
          Console.WriteLine(string.Format("{0} : {1}", (object) prop.Name, (object) prop.PropertyType));
          prop = (PropertyInfo) null;
        }
        propertyInfoArray = (PropertyInfo[]) null;
        Console.WriteLine("====================");
        Console.WriteLine("Methods");
        MethodInfo[] methodInfoArray = type.GetMethods();
        for (int index = 0; index < methodInfoArray.Length; ++index)
        {
          MethodInfo method = methodInfoArray[index];
          Console.WriteLine(string.Format("{0} : {1}", (object) method.Name, (object) method.ReturnType));
          method = (MethodInfo) null;
        }
        methodInfoArray = (MethodInfo[]) null;
      }
      code = (string) null;
      assembly = (Assembly) null;
    }

    private static void CreateObject()
    {
      Type type = typeof (ReflectionClass);
      if (Activator.CreateInstance(type) is ReflectionClass instance1)
        Console.WriteLine(string.Format("{0}, {1}", (object) instance1.fieldA, (object) instance1.fieldB));
      object[] objArray = new object[1]
      {
        (object) "Hello world!"
      };
      if (Activator.CreateInstance(type, objArray) is ReflectionClass instance2)
        Console.WriteLine(string.Format("{0}, {1}", (object) instance2.fieldA, (object) instance2.fieldB));
      PropertyInfo property = type.GetProperty("fieldB");
      if (property != (PropertyInfo) null)
      {
        property.SetValue((object) instance2, (object) "ABCDEFGHIJKL");
        Console.WriteLine(property.GetValue((object) instance2).ToString());
      }
      MethodInfo method1 = type.GetMethod("MethodStr");
      if (method1 != (MethodInfo) null)
        Console.WriteLine(method1.Invoke((object) instance2, new object[0]).ToString());
      MethodInfo method2 = type.GetMethod("MethodInt");
      if (method2 != (MethodInfo) null)
        Console.WriteLine((int) method2.Invoke((object) instance2, new object[1]
        {
          (object) 10
        }));
      Program.DemoClass demoClass = new Program.DemoClass();
      FieldInfo field = typeof (Program.DemoClass).GetField("constValue", BindingFlags.Instance | BindingFlags.NonPublic);
      if (field != (FieldInfo) null)
      {
        field.SetValue((object) demoClass, (object) -9.87645);
        Console.WriteLine(demoClass.Show());
      }
      Console.ReadKey();
    }

    public class DemoClass
    {
      private readonly double constValue = 1.23456;

      public double Show() => this.constValue;
    }
  }
}
