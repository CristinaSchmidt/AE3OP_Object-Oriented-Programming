using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Programming_Paradigms
{
    internal class Teacher
    {
        private string name;
        private string subject;
        private int yearsOfExperience;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public string Subject
        {
            get { return subject; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))throw new ArgumentException("Subject cannot be empty.");
                subject = value;
            }
        }

        public int YearsOfExperience
        {
            get { return yearsOfExperience; }
            set
            {
                if (value < 0) throw new ArgumentException("Years of experience cannot be negative.");
                yearsOfExperience = value;
            }
        }

        public Teacher(string name, string subject, int yearsOfExperience)
        {
            Name = name;
            Subject = subject;
            YearsOfExperience = yearsOfExperience;
        }

        public override string ToString()
        {
            return "Teacher: " + name + ", Subject: " + subject + ", Years of Experience: " + yearsOfExperience;
        }

        public void ShowProfile()
        {
            Console.WriteLine($"Teacher: {Name}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Years of experience: {YearsOfExperience}");
        }
    }
}
