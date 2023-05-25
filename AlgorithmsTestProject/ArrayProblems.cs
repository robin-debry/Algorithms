namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    private static object T;

    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        return xs.SequenceEqual(ys);
       
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {

        T temp = xs[a];
        xs[a] = xs[b];
        xs[b] = temp;
        
        

    }

    public static T FirstElement<T>(T[] xs)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        return xs.First();
    }

    public static T LastElement<T>(T[] xs)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        return xs.Last();
    }

    public static T MiddleElement<T>(T[] xs)
    {

        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        return xs[xs.Length / 2];
    }

    public static void Reverse<T>(T[] xs)
    {
        Array.Reverse(xs);
      
    }

    public static int CountElement<T>(T[] xs, T element)
    {
        return xs.Count(x => x.Equals(element));
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        return string.Join(",", xs);
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {

        return xs.Count(x => predicate(x));
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        return xs.Min();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        return xs.Max();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        HashSet<T> set = new HashSet<T>();
        foreach (T x in xs)
        {
            if (set.Contains(x))
            {
                return false;
            }
            set.Add(x);
        }
        return true;
    }
}