using System.Data.SqlTypes;
using System.Threading.Channels;
using Generics.CourseManage;

namespace Generics;

internal class Store<T> where T : class, IHasId
{
    private static readonly Dictionary<int, T> _items = new Dictionary<int, T>();

    public void Add(int id, T item)
    {
        if (_items.ContainsKey(id))
            throw new ArgumentException("Doublicated Id: Id is exsist !");
        else
            _items.Add(id, item);
    }
        


    public T GetById(int id)
    {   
        foreach (var item in _items)
        {
            if (id == item.Key)
                return item.Value;
        }

        return null;
    }

    public IReadOnlyDictionary<int, T> GetAll()
    {
        return _items;
    }

    public void Remove(int id)
    {
        if (!_items.Remove(id))
            throw new ArgumentException($"Item {id} is not found.");
    }
}
