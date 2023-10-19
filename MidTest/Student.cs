using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTest
{
    internal class Student
    {
        private int id;
        private string name;
        private string gender;
        private int age;
        private DateTime dateOfBirth;
        private string classs;
        private float mark1;
        private float mark2;
        private float mark3;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Class
        {
            get { return classs; }  
            set { classs = value; }
        }

        public float Mark1
        {
            get { return mark1; }
            set { mark1 = value; }
        }

        public float Mark2
        {
            get { return mark2; }
            set { mark2 = value; }
        }

        public float Mark3
        {
            get { return mark3; }
            set { mark3 = value; }
        }

        public float Mark_AVG()
        {
            return (mark1 + mark2 + mark3)/3;
        }

        public void Display()
        {
            Console.WriteLine("Id student: " + Id);
            Console.WriteLine("Name student: " + Name);
            Console.WriteLine("Gender student: " + Gender);
            Console.WriteLine("Age student: " +  Age);
            Console.WriteLine("Date of birth student:{0:dd/MM/yyyy} " , DateOfBirth);
            Console.WriteLine("Class student: " + Class);
            Console.WriteLine("Mark 1 student: " +  Mark1);
            Console.WriteLine("Mark 2 student: " + Mark2);
            Console.WriteLine("Mark 3 student: " + Mark3);
            Console.WriteLine("Mark_AVG: " + Mark_AVG());
        }
    }
}
