using System.Xml.Linq;
public class Task441
{
    void Traverse(Node current)
    {
        DoExpensiveActionOnNode(current);
        if (current.Left != null)
        {
            Task.Factory.StartNew(
            () => Traverse(current.Left),
            CancellationToken.None,
            TaskCreationOptions.AttachedToParent,
            TaskScheduler.Default);
        }
        if (current.Right != null)
        {
            Task.Factory.StartNew(
            () => Traverse(current.Right),
            CancellationToken.None,
            TaskCreationOptions.AttachedToParent,
            TaskScheduler.Default);
        }
    }
    void ProcessTree(Node root)
    {
        Task task = Task.Factory.StartNew(
        () => Traverse(root),
        CancellationToken.None,
        TaskCreationOptions.None,
        TaskScheduler.Default);
        task.Wait();
    }
}