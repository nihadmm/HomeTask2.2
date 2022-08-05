using System;

namespace HomeTask2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi=3.14;
            Console.WriteLine("Enter the radius: ");
            string r=Console.ReadLine();
            int radius=int.Parse(r);
            Console.WriteLine("perimeter of circle: "+2*pi*radius);
            Console.WriteLine("area of circle: "+pi*radius*radius);
            
        }
    }
}
