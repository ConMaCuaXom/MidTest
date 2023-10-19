using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checkprogram = true;
            TestStudent testStudent = new TestStudent();
            while (checkprogram)
            {
                int check;               
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("===================================================");
                Console.WriteLine("1. Input info");
                Console.WriteLine("2. Sorting student asccending by average mark");
                Console.WriteLine("3. Display all the student");
                Console.WriteLine("4. Search student by Name");
                Console.WriteLine("5. Delete student by Id");
                Console.WriteLine("6. Exit program");
                check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        testStudent.InputData();
                        break;
                    case 2:
                        Console.WriteLine("Chua lam xong");
                        break;
                    case 3:
                        Console.WriteLine("Display all student: ");
                        testStudent.DisplayAll();
                        break;
                    case 4:
                        Console.WriteLine("Input Name: ");
                        string Namee = Console.ReadLine();
                        testStudent.GetStudentsByName(Namee);
                        break;
                    case 5:
                        Console.WriteLine("Input Id: ");
                        int Idd = Convert.ToInt32(Console.ReadLine());
                        testStudent.DeleteStudentById(Idd);
                        Console.WriteLine("Delete Complete");
                        break;
                    case 6:
                        Console.WriteLine("Exit complelte!");
                        checkprogram = false;
                        break;
                    default:
                        Console.WriteLine("No option for this");
                        break;
                }
                           
            }
            Console.ReadKey();
        }
    }
}
