using Darbuotojai.Contracts;
using Darbuotojai.Models;
using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ManoPrograma
{
    public class PagrindineKlase
    {
        static void Main()
        {
            List<IEmployee> employees = new List<IEmployee>();

            while (true)
            {
                Console.WriteLine("1. Naujas darbuotoas:");
                Console.WriteLine("2. Naujas vadovas:");
                Console.WriteLine("0. Baigti programa:");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }

                IEmployee employee = null;
                if (choice == 1)
                {
                    employee = new Employee();
                }
                else if (choice == 2)
                {
                    employee = new Manager();
                }
                else
                {
                    Console.WriteLine("Ivedete klaidinga skaiciu");
                    continue;
                }

                employee.ReadData();
                employees.Add(employee);

                using (StreamWriter writer = new StreamWriter("C:\\Users\\mantv\\source\\repos\\Darbuotojai\\employees.txt", true))
                {
                    employee.SaveData(writer);
                }
            }

            Console.WriteLine("Duomenys is failo:");
            if (File.Exists("C:\\Users\\mantv\\source\\repos\\Darbuotojai\\employees.txt"))
            {
                string[] lines = File.ReadAllLines("C:\\Users\\mantv\\source\\repos\\Darbuotojai\\employees.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        Console.WriteLine($"Darbuotojo vardas: {parts[0]}, Amzius: {parts[1]}");
                    }
                    else if (parts.Length == 3)
                    {
                        Console.WriteLine($"Vadovo vardas: {parts[0]}, Amzius: {parts[1]}, Kiek darbuotoju vadovauja: {parts[2]}");
                    }
                }
            }

        }
    }
}
