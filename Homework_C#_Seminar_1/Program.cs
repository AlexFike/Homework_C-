/*
//Превая задача:
Console.Write("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if(value1 >= value2 || value2 >= value1)
    {
        if(value1 > value2)
        {
            Console.WriteLine("Число " + value1 + " больше числа " + value2);
        }
        if(value2 > value1)
        {
            Console.WriteLine("Число " + value2 + " больше числа " + value1);
        }
        if(value1 == value2)
        {
            Console.WriteLine("Числа равны");
        }
    }
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

// Третья задача:

Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

if(value % 2 == 0)
    {
        Console.WriteLine("Число " + value + " четное");
    }
else
    {
        Console.WriteLine("Число " + value + " нечетное");
    }
*/
// Четвертая задача:
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

if(value < 0)
{
    value = value * -1;
    int number = 2;
    if(value < 2 && value > -2)
    {
        Console.WriteLine("У числа нет четных значений");
    }
    else
    {
     while(number <= value)
        {
            Console.Write("-" + number + " ");
            number+=2;
        }
    }
}
else
{
int number = 2;
if(value < 2 && value > -2)
{
  Console.WriteLine("У числа нет четных значений");
}
else
{
while(number <= value)
    {
        Console.Write(number + " ");
        number+=2;
    }
}
}