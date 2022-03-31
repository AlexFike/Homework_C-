//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


void QuNum(int num)
{
    int count = 0;
    int i = 0;
    while(i < num)
    {
        Console.Write("Enter a number: ");
        int ComNum = Convert.ToInt32(Console.ReadLine());
        if(ComNum > 0) count++;
        i++;
    }
    Console.WriteLine($"Number of numbers greater than zero: {count}");
}

Console.Write("Enter the number of numbers you will be entering: ");
int number = Convert.ToInt32(Console.ReadLine());
QuNum(number);
