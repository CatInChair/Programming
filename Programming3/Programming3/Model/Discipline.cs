using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming3.Model
{
    public class Discipline
    {
        private string _name;
        private int _grade;
        private string _teacher;

        public string GetName()
        {
            return _name;
        }
        public int GetGrade()
        {
            return _grade;
        }
        public string GetTeacher() 
        {
            return _teacher;
        }

        public void SetName(string value)
        {
            _name = value;
        }
        public void SetGrade(int value) 
        { 
            if (value < 1 || value > 5)
            {
                throw new ArgumentException("Grade must be more than 0 and less than 6");
            }

            _grade = value;
        }
        public void SetTeacher(string value)
        {
            _teacher = value;
        }

        public Discipline(string name, int grade, string teacher)
        {
            this.SetName(name);
            this.SetTeacher(teacher);
            this.SetGrade(grade);
        }

        public Discipline() { }
    }
}
