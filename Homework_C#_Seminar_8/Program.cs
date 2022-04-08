// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] NewRandomMatrix(int rows, int columns, int start, int end)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(start, end);
        }
    }
    return matrix;
}


int[,] OrderingRowsMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int min = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != 0)
            {
                int value = j;
                while (j > 0)
                {
                    while (matrix[i, j] < matrix[i, j - 1])
                    {
                        min = matrix[i, j];
                        matrix[i, j] = matrix[i, j - 1];
                        matrix[i, j - 1] = min;
                    }
                    j--;
                }
                j = value;
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,2} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

//PrintMatrix(NewRandomMatrix(5, 5, 1, 5));
//PrintMatrix(OrderingRowsMatrix(NewRandomMatrix(5, 5, 1, 5)));
// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int MatrixRowsSmallerSum(int[,] matrix)
{
    int value = 1;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0) minSum = minSum + matrix[i, j];
            else sum = sum + matrix[i, j];
        }
        if (i != 0)
        {
            if (sum < minSum)
            {
                minSum = sum;
                value = i + 1;
            }
            else sum = 0;
        }
    }
    return value;
}
//Console.WriteLine(MatrixRowsSmallerSum((NewRandomMatrix(5, 8, 1, 5))));


// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)
int[,,] NewRandomTridimensionalMatrix(int dimensions, int rows, int columns, int start, int end)
{
    int[,,] dimensionMatrix = new int[dimensions, rows, columns];
    int variable = 0;
    Random random = new Random();
    for (int i = 0; i < dimensionMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < dimensionMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < dimensionMatrix.GetLength(2); k++, variable++)
            {
                int number = random.Next(start, end);
                for (int l = 0; l < dimensionMatrix.GetLength(0); l++)
                {
                    for (int m = 0; m < dimensionMatrix.GetLength(1); m++)
                    {
                        for (int n = 0; n < dimensionMatrix.GetLength(2); n++)
                        {
                            if(number == dimensionMatrix[l, m, n])
                            {
                                number = random.Next(start, end);
                                l = 0; m = 0; n = 0;
                            }
                        }
                    }
                }
                dimensionMatrix[i, j, k] = number;
            }
        }
    }
    return dimensionMatrix;
}




void PrintTridimensionalMatrix(int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"({i}, {j}, {k}): {matrix[i, j, k]}     ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
//PrintTridimensionalMatrix(NewRandomTridimensionalMatrix(2, 3, 4, 10, 100));
// Задача 4: Заполните спирально массив 4 на 4.

// На выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] FillSpiralMatrix(int rows, int columns)
{
    int[,] spiralMatrix = new int[rows, columns];
    int count = 1;
    int countX = 0;
    int countY = 0;
    int i = 0;
    int j = 0;
    while (count < rows * columns)
    {
        i = 0 + countY;

        for (j = 0 + countY; j < spiralMatrix.GetLength(1) - countX; j++, count++) spiralMatrix[i, j] = count;

        countX++;

        j = spiralMatrix.GetLength(1) - countX;

        for (i = 0 + countX; i < spiralMatrix.GetLength(0) - countY; i++, count++) spiralMatrix[i, j] = count;

        i = spiralMatrix.GetLength(0) - countX;

        for (j = spiralMatrix.GetLength(1) - 1 - countX; j >= countY; j--, count++) spiralMatrix[i, j] = count;

        j = 0 + countY;

        countY++;

        for (i = spiralMatrix.GetLength(0) - 1 - countX; i >= countY; i--, count++) spiralMatrix[i, j] = count;

        if (count == rows * columns) break;
    }
    return spiralMatrix;
}

PrintMatrix(FillSpiralMatrix(4, 4));
