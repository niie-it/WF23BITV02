using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02
{
    public class Person
    {
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public void Display()
        {
            Console.WriteLine($"Person {PersonId} {FullName} {Age}");
        }
        public override string ToString()
        {
            return $"Person {PersonId} {FullName} {Age}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.PersonId = "079080123456";
            p.FullName = "Trần Tèo";
            p.Age = 10;
            p.Display();
            Console.WriteLine(p);
            Console.WriteLine(p.ToString());
            var p2 = new Person()
            {
                PersonId = "07978978878",
                FullName = "Tí",
                Age = 3
            };
            Console.WriteLine(p2);

            List<Person> list = new List<Person>();
            list.Add(p);
            list.Add(p2);
            list.Add(new Person { Age = 1, FullName = "Tèo", PersonId = "1011" });
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
