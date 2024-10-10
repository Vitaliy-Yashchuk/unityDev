using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public int age { get; set; }
        public string name { get; set; }

        public Person(int age, string name) {
            this.age = age;
            this.name = name;
            personInfo();
        }
        public void personInfo()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}");
        }

    }
}
