// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create model, view, and controller
        Student model = new Student { Name = "Aiysha Ali", RollNo = "BT2230230" };
        StudentView view = new StudentView();
        StudentController controller = new StudentController(model, view);

        // Display initial state
        controller.UpdateView();

        // Update model via controller
        controller.SetStudentName("Aiysha Siddique");
        controller.SetStudentRollNo("BT9999999");

        Console.WriteLine("\nUpdated student data:");
        controller.UpdateView();
    }
}

