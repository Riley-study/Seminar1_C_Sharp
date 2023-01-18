// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
//элементов массива, значения которых лежат в отрезке [10,99].

using static System.Console;
Clear();
int[] ArrayToDoWiht = GetArray(123, 0, 1200);
PrintArray(ArrayToDoWiht);
int PrintCount = ArrayCount(ArrayToDoWiht);
WriteLine();
WriteLine($"количество элементов в указанном диапазоне значений {PrintCount}");



// Метод, который считает количество элементов в массиве, которые попадают в указанный диапазон
int ArrayCount(int[] inArray)
{
    int count = 0;
    foreach (int a in inArray)
    {
    if (a>9 && a<100) count+=1;
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