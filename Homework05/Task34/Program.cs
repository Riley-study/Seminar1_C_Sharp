// Задача 34: Напишите программу реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами, и подсчета количества 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

int[] InitialArray = GetArray(15, 100,1000);
PrintArray(InitialArray);

WriteLine();
int CountNumber = ArrayCount(InitialArray);
WriteLine($"Количество четных элементов в массиве: {CountNumber}");


// Метод, который считает количество четных элементов в массиве
int ArrayCount(int[] inArray)
{
    int count = 0;
    foreach (int a in inArray)
    {
    if (a%2 == 0) count+=1;
    }
    return count;
}
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