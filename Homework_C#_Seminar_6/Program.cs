//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


// void QuNum(int num)
// {
//     int count = 0;
//     int i = 0;
//     while(i < num)
//     {
//         Console.Write("Enter a number: ");
//         int ComNum = Convert.ToInt32(Console.ReadLine());
//         if(ComNum > 0) count++;
//         i++;
//     }
//     Console.WriteLine($"Number of numbers greater than zero: {count}");
// }

// Console.Write("Enter the number of numbers you will be entering: ");
// int number = Convert.ToInt32(Console.ReadLine());
// QuNum(number);

// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива.
// Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

void Matrix(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i ,j] = 0;
            array[0, j] = 1;
            array[i, 0] = 1;
            array[array.GetLength(0) - 1, j] = 1;
            array[i, array.GetLength(1) - 1] = 1;
            Console.Write($"{array[i, j]} ");
            
        }
        Console.WriteLine();
    }
}

Console.Write("Enter the number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of colums: ");
int c = Convert.ToInt32(Console.ReadLine());
Matrix(r, c);