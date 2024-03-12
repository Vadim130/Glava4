public class Task411
{
    public static void Main(string[] args)
    {
        Matrix m0 = new Matrix(new float[,]{ { 1, 0 }, { 0, 1 } });
        Matrix m1 = new Matrix(new float[,] { { 0, 1 }, { -1, 0 } });
        Matrix m2 = new Matrix(new float[,] { { -1, 0 }, { 0, -1 } });
        Matrix[] matrices = new Matrix[] { m0, m1, m2 };
        RotateMatrices(matrices, 90);
        foreach(Matrix matrix in matrices)
        {
            Console.WriteLine(matrix);
        }
    }
    static void RotateMatrices(IEnumerable < Matrix > matrices, float degrees)
    { 
        Parallel.ForEach(matrices, matrix => matrix.Rotate(degrees));
    }
}