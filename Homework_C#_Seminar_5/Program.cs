//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int ThreeNumber(int size)
{
    int[] ar = new int[size];
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        ar[i] = new Random().Next(100, 1000);
        if(ar[i] % 2 == 0) count++;    
    }
    return count;  
}

int SizeArray = 10;
Console.WriteLine($"Number of even elements in array {ThreeNumber(SizeArray)}");
*/
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int SumEvenNumbers(int size, int start, int end)
{
    int[] arR = new int[size];
    int sum = 0;
    for(int i = 0; i < size; i++)
    {
        arR[i] = new Random().Next(start, end);
        if(i % 2 != 0) sum = sum + arR[i];
    }
    return sum;
}
int ArRSize = 10;
int s = -5;
int e = 25;
Console.WriteLine($"Sum of all even numbers in array {SumEvenNumbers(ArRSize, s, e)}");