//Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
//Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел. 
//А теперь самое интересное: создавать массивы в процессе решения запрещено

void MinMax()
{
    Console.Write("Введите число: ");
    int Num = Convert.ToInt32(Console.ReadLine());
    if(Num == 0) Console.WriteLine("Не введено не одного числа для завершения!");
    else
    {
        int Max1 = Num;
        int Max2 = Num;
        int Min1 = Num;
        int Min2 = Num;
        Console.Write("Введите следующее число: ");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        if(Num2 == 0) Console.WriteLine("Введите не менее двух чисел!");
        else 
        {
            if(Num >= Num2)
            {
                Max1 = Num;
                Max2 = Num2;
                Min1 = Num2;
                Min2 = Num;
            }
            else
            {
                Max1 = Num2;
                Max2 = Num;
                Min1 = Num;
                Min2 = Num2;
            }
            Console.Write("Введите следующее число: ");
            int Num3 = Convert.ToInt32(Console.ReadLine());
            if(Num3 == 0) Console.WriteLine("Два максимальных числа: " + Max1 + " и " + Max2 + ", а два минимальных: " + Min1 + ", и " + Min2);
            else
            {
                while(Num3 < 0 || Num3 > 0)
                {
                    if(Num3 > Max2)
                    {
                        if(Num3 > Max1)
                        {
                            Max2 = Max1;
                            Max1 = Num3;
                        }
                        else Max2 = Num3;
                    }
                    if(Num3 < Min2)
                    {
                        if(Num3 < Min1)
                        {
                            Min2 = Min1; 
                            Min1 = Num3;
                        }
                        else Min2 = Num3;
                    }
                    if(Num3 == 0) break;
                    Console.Write("Введите следующее число: ");
                    Num3 = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Два максимальных числа: " + Max1 + " и " + Max2 + ", а два минимальных: " + Min1 + ", и " + Min2);   
            }
        }
    }
}
Console.WriteLine("Вводите числа которые будете сравнивать, для завршения введите 0!");
MinMax();