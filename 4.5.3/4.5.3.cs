public class Task453
{
    int ParallelSum(IEnumerable<int> values)
    {
        return values.AsParallel().Sum();
    }
}