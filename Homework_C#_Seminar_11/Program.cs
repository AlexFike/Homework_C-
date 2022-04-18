// int[] data = { 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0 };
// int[] info = { 2, 3, 3, 1, 2 };
(int[], int[]) NewArrays()
{
    int tumbler = 0;
    int sizeBinaryArray = 0;
    while (tumbler == 0)
    {
        Console.Write("Введи размер бинарного массива: ");
        sizeBinaryArray = Convert.ToInt32(Console.ReadLine());
        if (sizeBinaryArray <= 0) Console.WriteLine("Невозможно продолжить с пустым массивом!");
        else tumbler++;
    }
    int i = 0;
    int[] arrayBinary = new int[sizeBinaryArray];
    while (i < sizeBinaryArray)
    {
        Console.Write("Введите элемент бинарного массива: ");
        int binary = Convert.ToInt32(Console.ReadLine());
        if (binary != 0 && binary != 1) Console.WriteLine("Элементы бинарного массива могут быть только из двоичной систме счисления!");
        else
        {
            arrayBinary[i] = binary;
            i++;
        }
    }
    tumbler = 0;
    int sizeBitArray = 0;
    while (tumbler == 0)
    {
        Console.Write("Введите размер массива бит: ");
        sizeBitArray = Convert.ToInt32(Console.ReadLine());
        if (sizeBitArray <= 0) Console.WriteLine("Массив бит не может быть пустым!");
        else
        {
            if (sizeBitArray > sizeBinaryArray) Console.WriteLine("Массив бит не может быть больше бинарного массива!");
            else tumbler++;
        }
    }
    int[] arrayBit = new int[sizeBitArray];
    Console.WriteLine("Для каждого элемента зарезервирован минимальный размер, равный 1 биту!");
    int j = 0;
    int storage = arrayBit.Length - 1;
    while (j < arrayBit.Length)
    {
        Console.Write("Введите элемент массива бит(размер числа двоичной системы счисления): ");
        int bit = Convert.ToInt32(Console.ReadLine());
        if (bit <= 0) Console.WriteLine("Вы не выделили размер(количество бит) для числа двоичной системы счисления!");
        else
        {
            if (bit + storage - j > arrayBinary.Length) Console.WriteLine("Вы не можете указать размер выходящий за рамки бинарного массива!");
            else
            {
                arrayBit[j] = bit;
                j++;
            }
        }
    }
    return (arrayBinary, arrayBit);
}
//NewArrays();


int[] BinaryInDecimal((int[] arrayBinary, int[] arrayBit) arrays)
{
    int value = 0, degree;
    int[] arrayDecimal = new int[arrays.arrayBit.Length];
    for (int i = 0; i < arrays.arrayBit.Length; i++)
    {
        degree = arrays.arrayBit[i] - 1;
        for (int j = value; j < value + arrays.arrayBit[i]; j++, degree--)
        {
            arrayDecimal[i] += arrays.arrayBinary[j] * Convert.ToInt32(Math.Pow(2, degree));
        }
        value += arrays.arrayBit[i];
    }
    return arrayDecimal;
}


void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
}

Print(BinaryInDecimal(NewArrays()));