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
        return xs.First();
    }

    public static T LastElement<T>(T[] xs)
    {
        return xs.Last();
    }

    public static T MiddleElement<T>(T[] xs)
    {

        throw new NotImplementedException();
    }

    public static void Reverse<T>(T[] xs)
    {
      
    }

    public static int CountElement<T>(T[] xs, T element)
    {
       return Count(xs, x => x.Equals(element));
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        var r = "";
        for (var i=0; i<xs.Length;i++)
        {
            if (i>0)
            {
                r += ",";
                r += xs[i];
            }
            
        }
        return r;
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {

        return xs.Count();
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        throw new NotImplementedException();
    }
}