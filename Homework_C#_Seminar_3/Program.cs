//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да
/*
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

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double CoorPoint(double x1, double y1,double z1, double x2, double y2, double z2)
{
    double xDis = x2 - x1;
    double yDis = y2 - y1;
    double zDis = z2 - z1;
    return Math.Sqrt(Math.Pow(xDis, 2) + Math.Pow(yDis, 2) + Math.Pow(zDis, 2));
}

double xA, yA, zA, xB, yB, zB;
Console.Write("Введите X координаты точки A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y координаты точки A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z координаты точки A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X координаты точки B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y координаты точки B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z координаты точки B: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Растояние между точками = " + CoorPoint(xA, yA, zA, xB, yB, zB));
*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void CubeN(int number)
{
    int value = 1;
    double Num;
    while(value <= number)
    {
        Num = Math.Pow(value, 3);
        Console.Write(Num + " ");
        value++;
    }
}
int InNum;
Console.Write("Введите число для отображения таблицы кубов: ");
InNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов числа: ");
CubeN(InNum);
