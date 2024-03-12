public class Task451
{
    IEnumerable<int> MultiplyBy2(IEnumerable<int> values)
    {
        return values.AsParallel().Select(value => value * 2);
    }
}