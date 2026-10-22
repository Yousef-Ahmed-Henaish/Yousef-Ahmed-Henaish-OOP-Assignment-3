using Generics.StudentManage;

namespace Generics;

public class Program 
{
    public static void Main(string[] args)
    {
        Store<Student> StudentsStore = new Generics.Store<Student>();

        for(int i = 1;  i <= 10; i++) 
            StudentsStore.Add(i, new(i,$"Student {i}"));


        Console.WriteLine("10 Students");

        var AllStudents = StudentsStore.GetAll();

        foreach(var student in AllStudents)
            Console.WriteLine($"Name: {student.Value.Name}, Id: {student.Value.Id}");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        for (int i = 6; i <= 10; i++)
            StudentsStore.Remove(i);

        Console.WriteLine("After Removing: 5 Students");

        foreach (var student in AllStudents)
            Console.WriteLine($"Name: {student.Value.Name}, Id: {student.Value.Id}");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        var Student3 = StudentsStore.GetById(3);

        Console.WriteLine($"Studet number 3: {Student3.Name}");



    }
}