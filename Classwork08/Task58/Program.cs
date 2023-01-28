// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using static System.Console;
Clear();

int[,] InitMatrix = GetMatrixArray(4,4,1,10);
PrintMatrixArray(InitMatrix);
WriteLine("Меняем первую и последнюю строку массива местами:");
ChangeRows(InitMatrix);
PrintMatrixArray(InitMatrix);




// Метод, меняющий местами первую и последнюю строки в массиве
int[,] ChangeRows(int[,] inArray)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
    int i=0;
    int temp = inArray[i,j];
    inArray[i,j] = inArray[inArray.GetLength(0)-1, j];
    inArray[inArray.GetLength(0)-1, j] = temp;
}
return inArray;
}


//Метод, формирующий матрицу заданного размера в заданном диапозоне
int[,] GetMatrixArray(int rows, int colomns, int minValue, int maxValue)
{
    int[,] resultArray = new int[rows,colomns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            resultArray[i,j] = rnd.Next(minValue, maxValue+1);
        }
    }
    return resultArray;
}


// Метод, выводящий массив на печать
void PrintMatrixArray(int [,] inArray)
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
