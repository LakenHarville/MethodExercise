using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}. It's nice to meet you."); 
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($"{color}. That's my favorite too!");
            Console.WriteLine("What's your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine($"{animal}? That's such a strange choice, but alright.");
            Console.WriteLine("Alright, now who is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"{band}. You know, I've never even heard of them.");
            
        }
   
    }
}
