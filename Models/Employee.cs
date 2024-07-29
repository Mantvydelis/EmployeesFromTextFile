using Darbuotojai.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Darbuotojai.Models
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }

      

        public Employee (string name, int age)
        {
            Name = name;
            Age = age;
            
        }

        public virtual void ReadData()
        {
            Console.Write("Iveskite varda: ");
            Name = Console.ReadLine();

            Console.Write("Iveskite amziu: ");
            Age = int.Parse(Console.ReadLine());
        }

        public virtual void WriteData()
        {
            Console.WriteLine($"Vardas: {Name}, Amzius: {Age}");
        }

        public virtual void SaveData(StreamWriter writer)
        {
            writer.WriteLine($"{Name},{Age}");
        }

        public Employee() { }




    }
}
