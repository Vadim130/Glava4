
public class Task422
{
    int ParallelSum(IEnumerable<int> values)
    {
        return values.AsParallel().Aggregate(
        seed: 0,
        func: (sum, item) => sum + item
        );
    }
}