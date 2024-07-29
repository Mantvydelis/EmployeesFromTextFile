using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Darbuotojai.Models
{
    public class Manager : Employee
    {
        public int NumberOfEmployees { get; set; }


        public override void ReadData()
        {
            base.ReadData();
            Console.Write("Iveskite vadovaujamu darbuotoju skaiciu: ");
            NumberOfEmployees = int.Parse(Console.ReadLine());
        }

        public override void WriteData()
        {
            base.WriteData();
            Console.WriteLine($"Vadovujamu darbuotoju skaicius: {NumberOfEmployees}");
        }

        public override void SaveData(StreamWriter writer)
        {
            writer.WriteLine($"{Name},{Age},{NumberOfEmployees}");
        }


    }
}
