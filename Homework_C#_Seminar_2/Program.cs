
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