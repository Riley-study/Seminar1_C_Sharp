// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

using static System.Console;
Clear();

int[] FirstArray = GetArray(9, 1, 10);
PrintArray(FirstArray);
WriteLine();
int[] SecondArray = NumberPairs(FirstArray);
PrintArray(SecondArray);


//Метод, который перемножает пары в массиве и формирует новый массив
int[] NumberPairs(int[] inArray)
{
    int sizeArray = inArray.Length/2;
    if (inArray.Length % 2 == 1) sizeArray++;

    int[] ResultArray = new int[sizeArray];

    for (int i = 0; i < sizeArray; i++)
    {
        ResultArray[i]=inArray[i]*inArray[inArray.Length-1-i];
    }
    return ResultArray;
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