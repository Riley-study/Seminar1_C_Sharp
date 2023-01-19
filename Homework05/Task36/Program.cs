// Задача 36: Напишите программу реализующую методы формирования массива,
// заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
int[] InitialArray = GetArray(10, 10,20);
PrintArray(InitialArray);

WriteLine();
int CountSum = ArrayCount(InitialArray);
WriteLine($"Сумма элементов массива, стоящих на нечетных позициях: {CountSum}");




// Метод, который считает сумму элементов в массиве, стоящих на нечетных позициях
int ArrayCount(int[] inArray)
{
    int Count_Sum = 0;
    int i = 0;

    while(i<inArray.Length)
    {
        if ((i+1)%2==1) Count_Sum=Count_Sum+inArray[i];
        i++;
    }
    return Count_Sum;
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