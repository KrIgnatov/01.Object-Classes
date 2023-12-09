using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] studentData = input.Split();
            Student student = new Student
            {
                FirstName = studentData[0],
                LastName = studentData[1],
                Age = int.Parse(studentData[2]),
                HomeTown = studentData[3]
            };

            students.Add(student);
        }

        string cityName = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.HomeTown == cityName)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
