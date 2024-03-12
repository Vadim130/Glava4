
public class Task421
{


    // Примечание: это не самая эффективная реализация.
    // Это всего лишь пример использования блокировки
    // для защиты совместного состояния.
    int ParallelSum(IEnumerable<int> values)
    {
        object mutex = new object();
        int result = 0;
        Parallel.ForEach(source: values,
        localInit: () => 0,
        body: (item, state, localValue) => localValue + item,
        localFinally: localValue =>
        {
            lock (mutex)
                result += localValue;
        });
        return result;
    }
}