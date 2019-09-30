using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        private static List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Welcome to my first c# application. Feel free to try it out.");

            while(true){
                var input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase)){
                    break;
                } else if(input.Equals("help", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("-> Usable commands: exit, help, add, update, remove, list");
                }
                else if(input.Equals("add", StringComparison.OrdinalIgnoreCase)){
                    
                    Console.WriteLine("-> Please enter your name: ");
                    name = Console.ReadLine();

                    Console.WriteLine("-> Please enter your age: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("-> Your name and age are saved.");
                }else{
                    Console.WriteLine("-> '" + input + "'" + " is not a command. Type help for info.");
                }
            }
        }
    }
}
