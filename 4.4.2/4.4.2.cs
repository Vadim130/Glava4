using System.Diagnostics;
#if false
public class Task442
{
    Task task = Task.Factory.StartNew(
     () => Thread.Sleep(TimeSpan.FromSeconds(2)),
     CancellationToken.None,
     TaskCreationOptions.None,
     TaskScheduler.Default);
    Task continuation = task.ContinueWith(
     t => Trace.WriteLine("Task is done"),
     CancellationToken.None,
     TaskContinuationOptions.None,
     TaskScheduler.Default);
    // Аргумент "t" для продолжения - то же, что "task".
}
#endif