using System.Diagnostics;

namespace RefactoringLab.Part03.BlockedUsers;


public static class BlockedUserChecker
{
    public static int CountBlocked(List<int> blockedIds, int[] requestIds)
    {
        var blocked = 0;
        HashSet<int> searchIds = new HashSet<int>(blockedIds);

        foreach (var id in requestIds)
            if (searchIds.Contains(id))
                blocked++;

        return blocked;
    }

    public static List<int> BuildBlockedIds(int count)
    {
        return Enumerable.Range(0, count).ToList();
    }

    public static int[] BuildRequestIds(int count, int maxId, int seed = 42)
    {
        var rnd = new Random(seed);
        var ids = new int[count];
        for (var i = 0; i < count; i++)
            ids[i] = rnd.Next(maxId);
        return ids;
    }

    public static long MeasureMs(List<int> blockedIds, int[] requestIds, out int found)
    {
        var sw = Stopwatch.StartNew();
        found = CountBlocked(blockedIds, requestIds);
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
}
