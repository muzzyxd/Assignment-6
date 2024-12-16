using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class Animal
    {
        public abstract string MakeSound();
    }
    class Dog : Animal
    {
        public override string MakeSound()
        {
            return "Woof!";
        }
    }

    class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Meow!";
        }
    }


    class Cow : Animal
    {
        public override string MakeSound()
        {
            return "Moo";
        }
    }
        internal class Program
        {
        static void Main(string[] args)
        {
            Animal sound1 = new Dog();
            Console.WriteLine($"Dog sound:{sound1.MakeSound()}");

            Animal sound2 = new Cat();
            Console.WriteLine($"Cat sound:{sound2.MakeSound()}");

            Animal sound3 = new Cow();
            Console.WriteLine($"Cow sound:{sound3.MakeSound()}");

            Console.ReadLine();
        }
        }
    }
