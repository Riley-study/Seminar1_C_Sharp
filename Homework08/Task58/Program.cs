// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();

WriteLine("Матрица A: ");
int[,] MatrixA = GetMatrixArray(2, 2, 1, 5);
PrintMatrixArray(MatrixA);
WriteLine("Матрица B: ");
int[,] MatrixB = GetMatrixArray(2, 2, 1, 5);
PrintMatrixArray(MatrixB);

WriteLine("Матрица C = A x B: ");
int[,] MatrixC = ProductOfMatrix(MatrixA, MatrixB);
PrintMatrixArray(MatrixC);




//////////////////////////////////////////////// Methods ////////////////////////////////////////////////////

// Метод, рассчитывающий произведение двух матриц
int[,] ProductOfMatrix(int[,] inMatrixA, int[,] inMatrixB)
{
    int[,] result = new int[inMatrixA.GetLength(0), inMatrixB.GetLength(1)];
    for (int i = 0; i < inMatrixA.GetLength(0); i++)
    {
        for (int j = 0; inMatrixB.GetLength(1); j++)
        {
        int sum = 0;
            for (int m = 0; m < inMatrixA.GetLength(1); m++)
            {
                    sum += inMatrixA[i, m] * inMatrixB[m, j];
            }
        result[i, j] = sum;
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