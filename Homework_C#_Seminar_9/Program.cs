int[,] CreatePaskalTriangle(int size)
{
    int[,] matrix = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        matrix[i, 0] = 1;
        matrix[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
        }
    }
    PrintTriangleMatrix(matrix);
    return matrix;
}
CreatePaskalTriangle(21);

void PrintTriangleMatrix(int[,] matrix)
{
    int poinTop = Console.WindowTop + 1;
    int pointLeft = Console.WindowWidth / 2;
    int size;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        string str = " ";

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (matrix[i, j] != 0)
            {
                str = str + Convert.ToString(matrix[i, j]) + " ";
            }
        }

        size = str.Length / 2;
        pointLeft = pointLeft - size;

        Console.SetCursorPosition(pointLeft, poinTop);

        pointLeft = Console.WindowWidth / 2;
        poinTop++;

        Console.Write(str);
        Console.WriteLine();

    }
}
