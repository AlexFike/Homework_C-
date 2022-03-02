/*
// task one
int ModNum(int num)
{
    int num2 = num % 100;
    int num3 = num2 / 10;
    return num3;
}
// check
Console.Write("Введите трехзначное число число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Средняя цифра цисла " + ModNum(number));
*/
// task two
void ModNum2(int Num)
{
    if(Num / 100 == 0)
    {
        Console.WriteLine("У числа нет третьей цифры");
    }
    else
    {
        while(Num / 100 > 10)
        {
            Num = Num / 10;
        }
        Console.WriteLine("Третья цифра числа " + Num % 10);
    }
}
// check
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

ModNum2(number);
