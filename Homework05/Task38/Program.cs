// Задача 38: Напишите программу реализующую методы формирования массива, 
// заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.

// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
Clear();

int[] InitialArray = GetArray(10, 10, 100);
PrintArray(InitialArray);
WriteLine();

int Max = MaxValue(InitialArray);
int Min = MinValue(InitialArray);
int Diff =  Max - Min;
WriteLine($"Максимальный элемент: {Max}");
WriteLine($"Минимальный элемент: {Min}");
WriteLine($"Разница между максимальным и минимальным элементами в массиве: {Diff}");




// Метод, который ищет максимальное число в массиве
int MaxValue(int[] inArray)
{
    int i = 0;
    int MaxIndex = inArray[i];
    for (i = 0; i < inArray.Length - 1; i++)
    {
        if (MaxIndex < inArray[i + 1]) MaxIndex = inArray[i + 1];
    }
    return MaxIndex;
}

// Метод, который ищет минимальное число в массиве
int MinValue(int[] inArray)
{
    int i = 0;
    int MinIndex = inArray[i];
    for (i = 0; i < inArray.Length - 1; i++)
    {
        if (MinIndex > inArray[i + 1]) MinIndex = inArray[i + 1];
    }
    return MinIndex;
}

// метод, который формирует массив указанного диапозона
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

//Метод, который выводит на печать массив
void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}