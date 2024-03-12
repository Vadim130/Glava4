
public class Task413
{
    public static void Main(string[] args)
    {
        Matrix m0 = new Matrix(new float[,] { { 1, 0 }, { 0, 1 } });
        Matrix m1 = new Matrix(new float[,] { { 0, 1 }, { -1, 0 } });
        Matrix m2 = new Matrix(new float[,] { { 1, 1 }, { 1, 1 } });
        Matrix m3 = new Matrix(new float[,] { { -2, 0 }, { 0, -2 } });
        Matrix[] matrices = new Matrix[] { m0, m1, m2, m3 };
        CancellationToken tok = new CancellationToken();
        RotateMatrices(matrices,90, tok);
        foreach (Matrix matrix in matrices)
        {
            Console.WriteLine(matrix);
        }

    }
    static void RotateMatrices(IEnumerable<Matrix> matrices, float degrees,
     CancellationToken token)
    {
        Parallel.ForEach(matrices,
        new ParallelOptions { CancellationToken = token },
        matrix => matrix.Rotate(degrees));
    }
}