// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных
// элементов массива.

using static System.Console;
Clear();

Write("Введите размер массива мин и мач через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
WriteLine();
// Посчитаем сумму положительных и отрицательных членов массива
int negativeSum = 0;
int positiveSum = 0;

foreach (int a in array)
{
    negativeSum+=a<0? a: 0;
    positiveSum+=a>0? a: 0;
}
WriteLine($"сумма отрицательных элементов {negativeSum}, сумма положительных элементов  {positiveSum}");

// метод, который формирует массив указанного диапозона
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] resultArray=new int[size];
    Random rnd = new Random();
    for (int i=0; i<size; i++)
    {
        resultArray[i]=rnd.Next(minValue, maxValue+1);
    }
    return resultArray;
}

//Метод, который выводит на печать массив
void PrintArray(int[] inArray)
{
    Write("[");
    for (int i=0; i< inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
}