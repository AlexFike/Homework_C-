//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

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
