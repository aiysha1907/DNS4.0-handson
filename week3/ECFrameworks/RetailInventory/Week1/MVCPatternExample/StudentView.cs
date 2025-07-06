using System;

public class StudentView
{
    public void DisplayStudentDetails(string studentName, string studentRollNo)
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine($"Name: {studentName}");
        Console.WriteLine($"Roll No: {studentRollNo}");
    }
}
