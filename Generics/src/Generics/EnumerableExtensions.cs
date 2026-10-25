namespace Generics;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
        int skip = (pageNumber - 1) * pageSize;
        int currentIndex = 0;
        int itemsReturned = 0;

        foreach (var item in source)
        {
            // skip pages that I don't need it
            if(currentIndex < skip)
            {
                currentIndex++;
                continue;
            }

            yield return item;
            itemsReturned++;

            if (itemsReturned == pageSize)
                yield break;
        }
    }

    public static T FindById<T>(this IEnumerable<T> source, int id) where T: IHasId
    {
        foreach (var item in source)
        {
            if (item.Id == id)
                return item;
        }

        return default;
    }


    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
    {
        Dictionary<int, T> returnedDictionary = new Dictionary<int, T>();

        foreach (var item in source)
        {
            try
            {
                returnedDictionary.Add(item.Id, item);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"item with id: {item.Id} was not placed.\n{ex}");
            }
        }

        return returnedDictionary;
    }
}
