using System;

// MODEL
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
}

// VIEW
public class StudentView
{
    public void DisplayStudent(Student student)
    {
        Console.WriteLine("===== Student Details =====");
        Console.WriteLine($"ID         : {student.Id}");
        Console.WriteLine($"Name       : {student.Name}");
        Console.WriteLine($"Department : {student.Department}");
    }
}

// CONTROLLER
public class StudentController
{
    private readonly Student model;
    private readonly StudentView view;

    public StudentController(Student model, StudentView view)
    {
        this.model = model;
        this.view = view;
    }

    public void UpdateView()
    {
        view.DisplayStudent(model);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MVC Pattern ===\n");

        Student student = new Student
        {
            Id = 101,
            Name = "Roshan Shaik",
            Department = "Computer Science"
        };

        StudentView view = new StudentView();

        StudentController controller = new StudentController(student, view);

        controller.UpdateView();
    }
}