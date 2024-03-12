public class Task452
{
    IEnumerable<int> MultiplyBy2(IEnumerable<int> values)
    {
        return values.AsParallel().AsOrdered().Select(value => value * 2);
    }
}