
public class Task412
{
    public static void Main(string[] args)
    {
        Matrix m0 = new Matrix(new float[,] { { 1, 0 }, { 0, 1 } });
        Matrix m1 = new Matrix(new float[,] { { 0, 1 }, { -1, 0 } });
        Matrix m2 = new Matrix(new float[,] { { 1, 1 }, { 1, 1 } });
        Matrix m3 = new Matrix(new float[,] { { -2, 0 }, { 0, -2 } });
        Matrix[] matrices = new Matrix[] { m0, m1, m2, m3 };
        InvertMatrices(matrices);
        foreach (Matrix matrix in matrices)
        {
            Console.WriteLine(matrix);
        }

    }
    static void InvertMatrices(IEnumerable<Matrix> matrices)
    {
        Parallel.ForEach(matrices, (matrix, state) =>
        {
            if (!matrix.IsInvertible)
                state.Stop();
            else
                matrix.Invert();
        });
    }
}
