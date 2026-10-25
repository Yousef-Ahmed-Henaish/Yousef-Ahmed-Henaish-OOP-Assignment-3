using System.Drawing;
using System.Numerics;
using Generics.CourseManage;
using Generics.StudentManage;

namespace Generics;

public class Program 
{
    public static void Main(string[] args)
    {

        //Put 5 students in a Store<Student> and 3 courses in a Store<Course>; get one of each by id.

        Store<Student> students = new Store<Student>();
        Store<Course> courses = new Store<Course>();
        
        for(int i = 1; i < 5; i++)
        {
            students.Add(i, new(i, $"Student {i}"));

            if(i <= 3)
                courses.Add(i, new());
        }

        Console.WriteLine($"Student: {students.GetById(3).Name}, Course: {courses.GetById(3).Title}");


        //• Add a student with an id that already exists — catch the exception and print its message.

        //students.Add(1, new(1, $"Student {1}"));


        //• Print page 2(size 2) of the students, and call FindById on a plain List<Course>.
        List<string> Names = new List<string>();

        for (int i = 1; i < 10; i++)
            Names.Add($"item {i}");

        foreach(string name in Names.Page(2, 2))
        {
            Console.Write($"{name}, ");
        }

        //• Leave new Store<string>() as a commented -out line marked “must NOT compile”, and explain why in Answers.md.

        //String string = new Store<string>();
    }
}