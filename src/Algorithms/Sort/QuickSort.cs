namespace Algorithms.Sort;

public static class QuickSort
{
    public static IEnumerable<int> Sort(IEnumerable<int> source)
    {
        var list = source.ToList();

        switch (list.Count)
        {
            case 0:
            case 1:
                return list;
            default:
                var pivot = list.Count / 2;
                var less = list.Where(x => x < list[pivot]);
                var greater = list.Where(x => x > list[pivot]);
                
                var result = new List<int>();
                
                result.AddRange(Sort(less));
                result.Add(list[pivot]);
                result.AddRange(Sort(greater));

                return result;
        }
    }
}