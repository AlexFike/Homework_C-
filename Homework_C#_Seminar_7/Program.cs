// // Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// double[,] ArrayRealNumbers(int rows, int columns, int minValueGenerated, int maxValueGenerated, int point)
// {
//     double[,] newArray = new double[rows, columns];
//     Random numbers = new Random();
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             newArray[i, j] = Math.Round
//              ((numbers.Next(minValueGenerated, maxValueGenerated)
//              + numbers.NextSingle()), point);
//             //Console.Write("{0,6}", array[i, j]);
//         }
//         //Console.WriteLine();
//     }
//    return newArray;
// }
int enterRows = 3;
int enterColumns = 4;
int enterMinValueGenerated = 1;
int enterMaxValueGenerated = 10;
int enterNumbersAfterDecimalPoint = 1;

// // Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 1 7 -> такого числа в массиве нет

// void ElementPositionInArray(int positionRow, int positionColumn, double[,] incomingArray)
// {
//     double value = 0;
//     int tumbler = 0;
//     for (int i = 0; i < incomingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < incomingArray.GetLength(1); j++)
//         {
//             Console.Write("{0,6} ", incomingArray[i, j]);
//             if (i + 1 == positionRow && j + 1 == positionColumn)
//             {
//             value = incomingArray[i, j];
//             tumbler = 1;
//             }
//         }
//         Console.WriteLine();
//     }
//     if (tumbler == 0) Console.WriteLine("There is no such position in the array");
//     else Console.WriteLine($"Value of this element = {value}");
// }
// Console.Write("Enter a position in the element row: ");
// int posRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a position in the item column: ");
// int posColumns = Convert.ToInt32(Console.ReadLine());
// ElementPositionInArray(posRows, posColumns,
// ArrayRealNumbers(enterRows, enterColumns, enterMinValueGenerated, enterMaxValueGenerated, enterNumbersAfterDecimalPoint));

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticMeanArrayColumnElements(int rows, int columns, int start, int end)
{
    int[,] arr = new int[rows, columns];

    double value = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(start, end);
            Console.Write("{0,8} ", arr[i, j]);           
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            value = value + arr[i,j];
        }
        value = value / rows;
        Console.Write("{0,08} " , Math.Round(value, 1));
        value = 0;     
    }
}
ArithmeticMeanArrayColumnElements(enterRows, enterColumns, enterMinValueGenerated, enterMaxValueGenerated);