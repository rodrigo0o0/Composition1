using Composition1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Composition1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();
            Department department = new Department { Name = depName };
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior) : ");
            string level = Console.ReadLine();
            Console.Write("Base Salary : ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker?");
            int totalContracts = int.Parse(Console.ReadLine());

            Worker worker = new Worker(name,level,baseSalary,department);
            for (int i = 0; i < totalContracts; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours) : ");
                int duration = int.Parse(Console.ReadLine());



            }
        }
    }
}
