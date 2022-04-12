int[,] PaskalTriangle(int size)
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
    PrintPaskalTriangle(matrix);
    return matrix;
}
PaskalTriangle(50);

void PrintPaskalTriangle(int[,] Triangle)
{
    int pointTop = Console.WindowTop + 1;
    int pointLeft = Console.WindowWidth / 2;

    for (int i = 0; i < Triangle.GetLength(0); i++)
    {
        string str = "";

        for (int j = 0; j < Triangle.GetLength(1); j++)
        {
            if (Triangle[i, j] != 0)
            {
                str = str + Convert.ToString(Triangle[i, j]) + " ";
            }
        }

        pointLeft = pointLeft - str.Length / 2;

        Console.SetCursorPosition(pointLeft, pointTop);

        pointLeft = Console.WindowWidth / 2;
        pointTop++;

        Console.Write(str);
        Console.WriteLine();

    }
}
