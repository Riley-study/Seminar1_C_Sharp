// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();

int[,] InitArray = GetMatrixArray(7, 3, 1, 5);
PrintMatrixArray(InitArray);

int numberRowMinSum = SumRowsElements(InitArray);
WriteLine($"Номер строки с наименьшей суммой элементов: {numberRowMinSum}");




//////////////////////////////////////////////// Methods ////////////////////////////////////////////////////

// Метод, рассчитывающий сумму элементов в каждой строке и выводящий номер наименьшей:

int SumRowsElements(int[,] inArrray)
{
    int result = 0;
   
    // находим сумму элементов первой строки, приравниваем к переменной, с которой будем сравнивать все остальные

    int i = 0;
    int sum1 = 0;
    for (int j = 0; j < inArrray.GetLength(1); j++)
    {
        sum1 += inArrray[i, j];
    }

int minSumRows = sum1;
int minRowIndex = 0;

// проходим по всем остальным строкам
for (i = 1; i < inArrray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < inArrray.GetLength(1); j++)
    {
        sum += inArrray[i, j];
    }

    if (minSumRows > sum)
    {
        minSumRows = sum;
        minRowIndex = i;
    }
    result = minRowIndex + 1;
}
return result;
}



//Метод, формирующий матрицу заданного размера в заданном диапозоне
int[,] GetMatrixArray(int rows, int colomns, int minValue, int maxValue)
{
    int[,] resultArray = new int[rows, colomns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

// Метод, выводящий двумерный массив на печать
void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5}");
        }
        WriteLine();
    }
}