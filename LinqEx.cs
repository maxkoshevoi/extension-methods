using System.Collections.Generic;

public static class LinqEx
{
    public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> source, int count)
    {
        var enumerator = source.GetEnumerator();
        var queue = new Queue<T>(count + 1);

        while (enumerator.MoveNext())
        {
            queue.Enqueue(enumerator.Current);
            if (queue.Count > count)
            {
                yield return queue.Dequeue();
            }
        }
    }
}
