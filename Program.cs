using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Are you enjoying C#? (Yes or No)");
            string input = Console.ReadLine();

            switch(input)
            {
                case "Yes": Console.WriteLine("Cool... welcome to the rest of your life");break;
                case "No":  Console.WriteLine("Come on, man!");break;
                default: Console.WriteLine("#5 needs more input!");break;
            }
                
        }
    }
}
