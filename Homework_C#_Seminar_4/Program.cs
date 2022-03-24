//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Degree(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++) result = result * A;
    return result;
}

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());
while (numberB <= 0)
{
    Console.Write("Нужно ввести натуральную степень: ");
    numberB = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"{numberB} степень числа {numberA} ровна {Degree(B: numberB, A: numberA)}");
*/
//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
 int Sum(int number)
 {
    int result = 0;
    while(Math.Abs(number) % 10 > 0) 
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
 }
 
 Console.Write("Введите целое число: ");
 int N = Convert.ToInt32(Console.ReadLine());
 if(N / 10 == 0) Console.WriteLine($"Число {N} состоит из одной цифры!");
 else Console.WriteLine($"Сумма цифр числа {N} равна {Sum(N)}");
*/
//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void ARR(int size)
{
    while(size <= 0)
    {
        Console.Write("Задайте размер массива из натуральных чисел: ");
        size = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[size];
    for(int index = 0; index < size; index++)
    {
        Console.Write("Введите число: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        
    }
    for(int index = 0; index < size; index++) Console.Write($" {array[index]}");
    Console.Write(" - ваш массив=)");
}

Console.Write("Задайте размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
ARR(a);
