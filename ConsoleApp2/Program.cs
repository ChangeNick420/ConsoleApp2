using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("Hello, let's play rock, paper, scissors. I'll start. We show the sign when I say 'Shoot'. Ready?");
            Thread.Sleep(1000);
            Console.WriteLine("Yes/No");
            choice = Console.ReadLine();
            if(choice == "Yes")
            {
                choice = 
            }
            Console.WriteLine("Rock...");
            Thread.Sleep(300);
            Console.WriteLine("Paper...");
            Thread.Sleep(300);
            Console.WriteLine("Scissors...");
            Thread.Sleep(300);
            Console.WriteLine("Shoot!");
            Console.ReadLine();
        }
    }
}
