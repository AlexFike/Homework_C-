/*
//Превая задача:
Console.Write("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if(value1 > value2)
    {
        Console.WriteLine(value1 + " больше " + value2);
    }
else
    {
        Console.WriteLine(value2 + " больше " + value1);
    }
*/
// Вторая задача:

Console.Write("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int value3 = Convert.ToInt32(Console.ReadLine());

int value_max = 0;

if(value1 > value_max)
    {
       value_max = value1;
    }
if(value2 > value_max)
    {
        value_max = value2;
    }
if(value3 > value_max)
    {
        value_max = value3;
    }
Console.WriteLine("Наибольшее число " + value_max);