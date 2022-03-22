//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Degree(int A, int B)
{
    int result = A;
    for(int i = 1; i < B; i++)  result = result * A;
    return result;
}

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberB <= 0)
{
    while(numberB < 1) 
    {
        Console.Write("Нужно ввести натуральную степень: ");
        numberB = Convert.ToInt32(Console.ReadLine());
    }
}
Console.Write($"{numberB} степень числа {numberA} ровна {Degree(B: numberB, A: numberA)}");