// **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

using static System.Console;
Clear();

int[,] InitMatrix = GetMatrixArray(5, 5, -10, 10);
PrintMatrixArray(InitMatrix);

if (InitMatrix.GetLength(0) != InitMatrix.GetLength(1))
{
    WriteLine("транспотрировать матрицу невозможно");
}
else
{
    WriteLine("Новый массив");
    int[,] NewArray = ChangeRowsOnColomns(InitMatrix);
    PrintMatrixArray(NewArray);
}





// Метод, меняющий местами строки со столбцами в массиве
int[,] ChangeRowsOnColomns(int[,] inArray)
{
    //if(inArray.GetLength(0)!=inArray.GetLength(1))
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[j, i] = inArray[i, j];
        }
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


// Метод, выводящий массив на печать
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
