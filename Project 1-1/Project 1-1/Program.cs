using System;

namespace result
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your FristName: ");
            String fristName = Console.ReadLine();
            Console.WriteLine("Enter Your LastName : ");
            String LastName = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your FristName is: " + fristName);
            Console.WriteLine("Your lastName is:" + LastName);
            Console.WriteLine("Your Age is :" + age);
            Console.WriteLine("Your Weight  is : " + weight);

            Console.ReadLine();
        }
    }
}