//**Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на 
//главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using static System.Console;
Clear();

WriteLine("Введите размер матрицы и диапозон значений через пробел");
int[] intParams=Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries),int.Parse);
int[,] newMatrix = GetMatrixArrray(intParams[0], intParams[1],intParams[2],intParams[3]);
PrintMatrixArray(newMatrix);
WriteLine($"Сумма диагоныльных элементов матрицы равна: {SumDiagonal(newMatrix)}");



// Метод,который формирует двумерный массив с указанным кол-ом строк и столбцов и 
//заполняет его случайными значениями в указанном интервале
int[,] GetMatrixArrray(int rows, int colomns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, colomns];
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

// Метод, суммирующий диагональные элементы массива
int SumDiagonal(int[,] inArray)
{
    int sumResult = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i==j) sumResult+=inArray[i,j];
        }
    }
    return sumResult;
}