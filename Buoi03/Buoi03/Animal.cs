using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03
{
    public class Animal
    {
        protected void Sleep() => Console.WriteLine("Animal is sleeping.");
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class Dog : Animal
    {
        public void XYZ()
        {
            Sleep();
        }
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
}
