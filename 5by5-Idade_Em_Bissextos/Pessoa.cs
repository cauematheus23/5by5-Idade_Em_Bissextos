using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Idade_Em_Bissextos
{
    internal class Pessoa
    {
        string name;
        int age, leapyears = 0;
        string job;

        public Pessoa(string name, int age, string job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }
        public void LeapYears()
        {
            int year = 2024 - age;
            
            while (year <= 2024) 
            {
                if (DateTime.IsLeapYear(year))
                {
                    leapyears++;
                }
                year++;
            }
         }
        
        public void Print()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Job: " + this.job);
            Console.WriteLine("Leap years: " + this.leapyears);
        }

    }
}
