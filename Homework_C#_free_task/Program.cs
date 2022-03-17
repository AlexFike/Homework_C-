//Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
//Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел. 
//А теперь самое интересное: создавать массивы в процессе решения запрещено

/*Console.WriteLine("Вводите числа которые будете сравнивать, для завршения введите 0!");
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
MaxMin(Number);


void MaxMin(int Num)
{
    int Max1 = 0;
    int Max2 = 0;
    int Min1 = 0;
    int Min2 = 0;
    int Num2 = 1;
    int Num3 = 1;
    if(Num == 0)
    {
        Console.WriteLine("Не введено не одного числа для завершения!");
    }
    else
    {
        Console.Write("Введите следующее число: ");
        Num2 = Convert.ToInt32(Console.ReadLine());
        if(Num2 == 0) Console.WriteLine("Введите не менее двух чисел!");
        else 
        {
            Console.Write("Введите следующее число: ");
            Num3 = Convert.ToInt32(Console.ReadLine());
            if(Num >= Num2)
            {
                Max1 = Num;
                Max2 = Num2;
                Min1 = Num2;
                Min2 = Num;
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
            else
            {
                Max1 = Num2;
                Max2 = Num;
                Min1 = Num;
                Min2 = Num2;
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
}
*/
void Numbers()
{
    int Num2 = 1;
    int Num3 = 1;
    Console.Write("Введите число: ");
    int Num = Convert.ToInt32(Console.ReadLine());
    if(Num == 0) Console.WriteLine("Не введено не одного числа для завершения!");
    else
    {
        Console.Write("Введите следующее число: ");
        Num2 = Convert.ToInt32(Console.ReadLine());
        if(Num2 == 0) Console.WriteLine("Введите не менее двух чисел!");
        else 
        {
            Console.Write("Введите следующее число: ");
            Num3 = Convert.ToInt32(Console.ReadLine());
            MaxMin(Num, Num2, Num3);
        }
    }
}
void MaxMin(int Numb, int Numb2, int Numb3)
{
    int Max1 = 0;
    int Max2 = 0;
    int Min1 = 0;
    int Min2 = 0;
    if(Numb3 == 0)
    {
        if(Numb >= Numb2)
            {
                Max1 = Numb;
                Max2 = Numb2;
                Min1 = Numb2;
                Min2 = Numb;
                if(Numb3 == 0) Console.WriteLine("Два максимальных числа: " + Max1 + " и " + Max2 + ", а два минимальных: " + Min1 + ", и " + Min2);
                else MaxMin2(Max1, Max2, Min1, Min2, Numb3);
            }
            else
            {
                Max1 = Numb2;
                Max2 = Numb;
                Min1 = Numb;
                Min2 = Numb2;
                if(Numb3 == 0) Console.WriteLine("Два максимальных числа: " + Max1 + " и " + Max2 + ", а два минимальных: " + Min1 + ", и " + Min2);  
                else MaxMin2(Max1, Max2, Min1, Min2, Numb3);
            }
    }
}
void MaxMin2(int max1, int max2, int min1, int min2, int number)
{
while(number < 0 || number > 0)
    {
        if(number > max2)
        {
            if(number > max1)
            {
                max2 = max1;
                max1 = number;
            }   
            else max2 = number;
        }
        if(number < min2)
        {
                if(number < min1)
                {
                    min2 = min1; 
                    min1 = number;
                }
                else min2 = number;
        }
        if(number == 0) break;
        Console.Write("Введите следующее число: ");
        number = Convert.ToInt32(Console.ReadLine());        
    }
    Console.WriteLine("Два максимальных числа: " + max1 + " и " + max2 + ", а два минимальных: " + min1 + ", и " + min2);
}

Console.WriteLine("Вводите числа которые будете сравнивать, для завршения введите 0!");
Numbers();