public class Task432
{
    void DoAction20Times(Action action)
    {
        Action[] actions = Enumerable.Repeat(action, 20).ToArray();
        Parallel.Invoke(actions);
    }
}
