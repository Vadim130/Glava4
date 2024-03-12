public class Task422
{
    public static

    int ParallelSum(IEnumerable<int> values)
    {
        return values.AsParallel().Sum();
    }
}