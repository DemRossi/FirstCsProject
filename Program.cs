using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name;
            // int age;
            var myList = new List<string>();

            for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Please enter a number");
                    Console.WriteLine(string.Join(",", myList));
                    myList.Add(Console.ReadLine());
                }

            // Console.WriteLine("Enter your name: ");
            // name = Console.ReadLine();

            // Console.WriteLine("Enter your age: ");
            // age = Convert.ToInt32(Console.ReadLine());


              
            // if(age>=18){
            //     Console.WriteLine("Hello, " + name + "!" + " Your age is " + age + ".");
            // }else if (age<=18){
            //     Console.WriteLine("Hello, " + name + "!" + " Your age is " + age + ". Your under aged!!!");
            // }
            // Console.ReadLine();
        }
    }
}
