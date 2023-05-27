// Decompiled with JetBrains decompiler
// Type: ReflectionExample.ReflectionTest
// Assembly: ReflectionExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 55589AB4-F7C6-445B-9741-FEF5A642B813
// Assembly location: C:\Users\emilp\source\repos\Dzien09-10\ReflectionExample\bin\Debug\ReflectionExample.exe

using System;
using System.Reflection;

namespace ReflectionExample
{
  public static class ReflectionTest
  {
    public static int fieldA;
    public static double fieldB;
    public static string fieldC;
    public static bool fieldD;
    private static DateTime fieldE = DateTime.UtcNow;

    public static int Test1() => 1;

    private static double Test2() => 1.1;

    public static bool Test3() => false;

    public static void Lookup()
    {
      Type type = typeof (ReflectionTest);
      foreach (FieldInfo field in type.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
        Console.WriteLine(string.Format("[{0}] - {1}", (object) field.Name, field.GetValue((object) null)));
      foreach (MethodInfo method in type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
        Console.WriteLine(string.Format("[{0}] - {1}", (object) method.Name, (object) method.ReturnType));
      Console.ReadKey();
    }
  }
}
