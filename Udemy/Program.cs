using Coding.Exercise;
using System;

namespace Coding.Exercise
{

    // place for your classes and an interface
    public interface IShootable
    {

        public void Shoot()
        {
        }
    }

    public class Weapon
    {
        public string name;

        public void Label()
        {
            Console.WriteLine($"This is {name}");
        }
}

public class Gun : Weapon, IShootable
{
   public Gun()
        {
            name = "Gun";
        }
        
        public void Shoot(){
            Console.WriteLine("Bang");
        }
    }
    
    public static class Program
{
    static public void Main(string[] args)
    {
        // new instance 
        Gun pist = new Gun();

        // test for methods
        pist.Label();
        pist.Shoot();

        // verifying the interface and the parent class
        if (pist is IShootable && pist is Weapon)
            System.Console.WriteLine("Yes, it is my parents.");
    }
}
}
