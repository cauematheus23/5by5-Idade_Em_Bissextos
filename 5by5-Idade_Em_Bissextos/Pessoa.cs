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
        int age;
        string job;

        public Pessoa()
        {
            
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setJob(string job)
        {
            this.job = job;
        }
        public int LeapYears()
        {
            int leapyears = 0;
            int year = DateTime.Now.Year - age;
            while (year <= 2024) 
            {
                if (DateTime.IsLeapYear(year))
                {
                    leapyears++;
                }
                year++;
            }
            return leapyears;
         }

        public override string? ToString()
        {
            return "Name: " + this.name + "\nAge: " + this.age + "\nJob: " + this.job + "\nAge in leap years: " + LeapYears();
        }
    }
}
