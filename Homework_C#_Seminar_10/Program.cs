// Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
// третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

// Пример:

// входные данные:
// int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
// int[] info = {2, 3, 3, 1 };

// выходные данные:
// 1, 7, 0, 1

int[] data = { 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0 };
int[] info = { 2, 3, 3, 1, 2 };


int[] BinaryInDecimal(int[] arrayBinary, int[] arrayByte)
{
    int value = 0, degree;
    int[] arrayDecimal = new int[arrayByte.Length];
    for (int i = 0; i < arrayByte.Length; i++)
    {
        degree = arrayByte[i] - 1;
        for (int j = value; j < value + arrayByte[i]; j++, degree--)
        {
            arrayDecimal[i] += arrayBinary[j] * Convert.ToInt32(Math.Pow(2, degree));
        }
        value += arrayByte[i];
    }
    return arrayDecimal;
}


void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
}

Print(BinaryInDecimal(data, info));