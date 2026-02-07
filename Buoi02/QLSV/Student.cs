using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class Student
    {
        public string FullName { get; set; }
        public string Major { get; set; }
        public double Gpa
        {
            get => _gpa;
            set
            {
                if (value >= 0 && value <= 4) { _gpa = value; }
                else
                {
                    throw new Exception("GPA must in [0.0 - 4.0]");
                }
            }
        }
        public int Id
        {
            get => _id; // get{ return _id;}
            set
            {
                if (value > 0) { _id = value; }
                else
                {
                    throw new Exception("Id must > 0");
                }
            }
        }

        private int _id;
        private double _gpa;

        public Student() { }
        public Student(string fullName, string major, double gpa, int id)
        {
            FullName = fullName;
            Major = major;
            Gpa = gpa;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"{Id}, {FullName}, {Major}, GPA: {Gpa}";
        }
    }
}
