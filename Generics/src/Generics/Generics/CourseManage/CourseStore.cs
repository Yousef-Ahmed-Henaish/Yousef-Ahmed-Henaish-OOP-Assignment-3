using Generics.CourseManage;

namespace Generics.CourseManage;

internal class CourseStore
{
    private static readonly List<Course> _courses = new List<Course>();

    public static void Add(Course course)
        => _courses.Add(course);


    public static Course? GetById(int id)
    {
        foreach (var course in _courses)
        {
            if (id == course.Id)
                return course;
        }
        return null;
    }

    public static List<Course> GetAll()
    {
        return _courses;
    }

    public static void Remove(int id)
    {
        foreach (var course in _courses)
        {
            if (id == course.Id)
                _courses.Remove(course);
        }
    }
}
