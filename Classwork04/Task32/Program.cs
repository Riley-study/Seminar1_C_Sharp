// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.

using static System.Console;
Clear();

Write("Введите размер массива мин и мач через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
WriteLine();
int[] ReversArray = ChangeSing(array);
PrintArray(ReversArray);

// Метод, который меняет знак у каждого члена массива
int[] ChangeSing(int[] array1)
{
    for(int i=0; i<array1.Length; i++)
    {
        array1[i]*=-1;
    }
    return array1;
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