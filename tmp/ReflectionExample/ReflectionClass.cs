// Decompiled with JetBrains decompiler
// Type: ReflectionExample.ReflectionClass
// Assembly: ReflectionExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 55589AB4-F7C6-445B-9741-FEF5A642B813
// Assembly location: C:\Users\emilp\source\repos\Dzien09-10\ReflectionExample\bin\Debug\ReflectionExample.exe

namespace ReflectionExample
{
  public class ReflectionClass
  {
    public int fieldA { get; set; }

    public string fieldB { get; set; }

    public ReflectionClass()
    {
      this.fieldA = 1234;
      this.fieldB = "ABCD";
    }

    public ReflectionClass(string s) => this.fieldB = s;

    public int MethodInt(int ratio) => this.fieldA * ratio;

    public string MethodStr() => this.fieldB.ToLower();
  }
}
