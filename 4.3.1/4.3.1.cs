public class Task431
{


    void ProcessArray(double[] array)
    {
        Parallel.Invoke(
        () => ProcessPartialArray(array, 0, array.Length / 2),
        () => ProcessPartialArray(array, array.Length / 2, array.Length)
        );
    }
    void ProcessPartialArray(double[] array, int begin, int end)
    {
        // Обработка, интенсивно использующая процессор...
    }
}