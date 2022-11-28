namespace AlgoList;

public static class PascalTriangle
{
    private static int[,] pascal = new int[7, 7];
    public static void PascalTriangleBuild(int series=7)
    {

        for (int i = 0; i < series; i++)
        {
            for (int k = series; k > i; k+=-1)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                if (j == 0 || i == j)
                {
                    pascal[i, j] = 1;
                }
                else
                {
                    pascal[i, j] = pascal[i - 1, j] + pascal[i - 1, j - 1];
                }
                Console.Write(pascal[i, j]+" ");
            }

            Console.ReadLine();
        }
    }
}