using System;
using System.Collections.Generic;

namespace _03.StudentSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "Exit")
                {
                    break;
                }
                else if (input[0] == "Create")
                {
                    student.CreateStudent(input[1], input[2], input[3]);
                }
                else
                {
                    Console.WriteLine(student.ShowStudentInfo(input[1])); 
                }
            }
        }
    }

    public class Student
    {
        private List<string> studentInfo = new List<string>();
        private string typeOfStudent;
        public void CreateStudent(string name, string age, string studentGrade)
        {
            if (double.Parse(studentGrade) >= 5)
            {
                typeOfStudent = "Excellent student.";
            }
            else if (double.Parse(studentGrade) >= 3.50 && double.Parse(studentGrade) < 5)
            {
                typeOfStudent = "Average student.";
            }
            else
            {
                typeOfStudent = "Very nice person.";
            }
            studentInfo.Add(String.Format("{0} is {1} years old. {2}", name, age, typeOfStudent));
        }

        public string ShowStudentInfo(string name)
        {
            return studentInfo.Find(student => student.Contains(name));
        }
    }
}
