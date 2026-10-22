using System.Data.SqlTypes;
using System.Threading.Channels;
using Generics.CourseManage;

namespace Generics;

internal class Store<T> where T : class, IHasId
{
    private static readonly List<T> _items = new List<T>();

    public static void Add(T t)
        => _items.Add(t);


    public static T GetById(int id)
    {
        foreach (var T in _items)
        {
            if (id == T.Id)
                return T;
        }

        return null;
    }

    public static List<T> GetAll()
    {
        return _items;
    }

    public static void Remove(int id)
    {
        int index = _items.FindIndex(item => item.Id == id);
        string message = string.Empty;

        if (index == -1)
        {
            Console.WriteLine("Item Not found");
        }   
        else
        {
            _items.RemoveAt(index);
            Console.WriteLine($"Iteml in Index {index} was Deleted.");
        }
    }
}
