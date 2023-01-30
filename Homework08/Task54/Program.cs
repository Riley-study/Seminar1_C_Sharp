// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();

int[,] InitArray = GetMatrixArray(5, 5, 1, 10);
PrintMatrixArray(InitArray);
WriteLine("Отсотированная матрица: ");
int[,] SortedArray = FromMaxToMin(InitArray);
PrintMatrixArray(SortedArray);



//////////////////////////////////////////////// Methods ////////////////////////////////////////////////////

// Метод, упорядычивающий по убыванию элементы каждой строки двумерного массива
int[,] FromMaxToMin(int[,] inArray)
{
    int[,] ResultArray = new int[inArray.GetLength(0), inArray.GetLength(1)];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            int temp;
            for (int n = j + 1; n < inArray.GetLength(1); n++)
            {
                if (inArray[i, j] < inArray[i, n])
                {
                    temp = inArray[i, j];
                    inArray[i, j] = inArray[i, n];
                    inArray[i, n] = temp;
                }
            }
    ResultArray[i, j] = inArray[i, j];
        }
    }
    return ResultArray;
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