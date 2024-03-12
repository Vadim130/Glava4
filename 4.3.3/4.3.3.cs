public class Task433
{
    void DoAction20Times(Action action, CancellationToken token)
    {
        Action[] actions = Enumerable.Repeat(action, 20).ToArray();
        Parallel.Invoke(new ParallelOptions { CancellationToken = token },
        actions);
    }
}