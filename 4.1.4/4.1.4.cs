
public class Task414
    {
    public static void Main(string[] args)
    {
        Matrix m0 = new Matrix(new float[,] { { 1, 0 }, { 0, 1 } });
        Matrix m1 = new Matrix(new float[,] { { 0, 1 }, { -1, 0 } });
        Matrix m2 = new Matrix(new float[,] { { 1, 1 }, { 1, 1 } });
        Matrix m3 = new Matrix(new float[,] { { -2, 0 }, { 0, -2 } });
        Matrix m4 = new Matrix(new float[,] { { 1, 1 }, { -1, -1 } });
        Matrix[] matrices = new Matrix[] { m0, m1, m2, m3, m4 };
        int count = InvertMatrices(matrices);
        foreach (Matrix matrix in matrices)
        {
            Console.WriteLine(matrix);
        }
        Console.WriteLine("Not inverted: " + count);

    }

    // Примечание: это не самая эффективная реализация.
    // Это всего лишь пример использования блокировки
    // для защиты совместного состояния.
    static int InvertMatrices(IEnumerable<Matrix> matrices)
    {
        object mutex = new object();
        int nonInvertibleCount = 0;
        Parallel.ForEach(matrices, matrix =>
        {
            if (matrix.IsInvertible)
            {
                matrix.Invert();
            }
            else
            {
                lock (mutex)
                {
                    ++nonInvertibleCount;
                }
            }
        });
        return nonInvertibleCount;
    }
}