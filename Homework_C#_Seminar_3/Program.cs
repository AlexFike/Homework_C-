//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

void PalNum(int num)
{
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num3 = num % 10; 
    int num4 = (num / 10) % 10;
    if(num1 == num3 && num2 == num4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else 
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
int number;
Console.Write("Введите пятизначное целое число, чтобы узнать, является ли оно палиндромом: ");
number = Convert.ToInt32(Console.ReadLine());
PalNum(number);
