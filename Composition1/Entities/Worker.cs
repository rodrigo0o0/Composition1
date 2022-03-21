using Composition1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department department { get; set; }

        List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, string level, double baseSalary, Department department)
        {
            Name = name;
            WorkLevel lvl;
            Enum.TryParse<WorkLevel>(level, out lvl);
            Level = lvl;
            BaseSalary = baseSalary;
            this.department = department;
        }

        public void AddContract(HourContract hc)
        {
            Contracts.Add(hc);
        }

        public void RemoveContract(HourContract hc)
        {
            Contracts.Remove(hc);
        }
        public double Income(int year, int month)
        {
            double income = BaseSalary;
            foreach (HourContract hc in Contracts)
            {
                if (hc.Date.Month == month && hc.Date.Year == year)
                {
                    income += hc.TotalValue();

                }
            }
            return income;
        }

    }
}
