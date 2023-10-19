using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTest
{
    internal class TestStudent
    {
        public List<Student> Students = new List<Student>();


        public void InputData()
        {
            Student stu = new Student();
            Console.WriteLine("Input Id: ");
            stu.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Name: ");
            stu.Name = Console.ReadLine();
            Console.WriteLine("Input Gender: ");
            stu.Gender = Console.ReadLine();
            Console.WriteLine("Input Age: ");
            stu.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Date of birth: ");
            stu.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Input Class: ");
            stu.Class = Console.ReadLine();
            Console.WriteLine("Input Mark1: ");
            stu.Mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Mark2: ");
            stu.Mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Mark3: ");
            stu.Mark3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark AVG: " + stu.Mark_AVG());

            Students.Add(stu);
        }

        public List<Student> GetStudentsByName(string name)
        {
            List<Student> studentsByName = new List<Student>();
            foreach (var item in Students)
            {
                if (item.Name == name)
                {
                    studentsByName.Add(item);
                    item.Display();
                }
            }
            return studentsByName;
        }

        public void DeleteStudentById(int id)
        {            
            foreach (var item in Students)
            {
                if (item.Id == id)
                {
                    Students.Remove(item);
                    break;
                }
            }           
        }

        public void EditStudentById(int id)
        {
            DeleteStudentById(id);
            InputData();
        }

        public void DisplayAll()
        {
            foreach(var item in Students)
            {
                item.Display();
            }
        }
    }
}

