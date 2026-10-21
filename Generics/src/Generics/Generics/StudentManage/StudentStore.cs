namespace Generics.StudentManage;

internal class StudentStore
{
    private static readonly List<Student> _students = new List<Student>();

    public static void Add(Student student)
        => _students.Add(student);


    public static Student? GetById(int id)
    {
        foreach(var student in _students)
        {
            if(id == student.Id)
                return student;
        }
        return null;
    }

    public static List<Student> GetAll()
    {
        return _students;
    }

    public static void Remove(int id)
    {
        foreach (var student in _students)
        {
            if (id == student.Id)
                _students.Remove(student);
        }
    }
}
