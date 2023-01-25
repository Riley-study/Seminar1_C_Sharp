// Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4

using static System.Console;
Clear();

WriteLine("Введите размер матрицы и диапозон значений через пробел");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[,] InitArray = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]),int.Parse(parametrs[2]),int.Parse(parametrs[3]));
WriteLine("Исходный массив:");
PrintMatrixArray(InitArray);
SquareEvenElements(InitArray, int.Parse(parametrs[0]), int.Parse(parametrs[1]));
WriteLine();
WriteLine("Преобразованный массив:");
PrintMatrixArray(InitArray);



//Метод, формирующий матрицу заданного размера в заданном диапозоне
double[,] GetMatrixArray(int rows, int colomns, int minValue, int maxValue)
{
    double[,] resultArray = new double[rows,colomns];
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
void PrintMatrixArray(double [,] inArray)
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


//Метод, возводящий в квадрат элементы массива, у которых оба индекса четные

double[,] SquareEvenElements(double[,] inArray, int rows, int colomns)
{
    //double[,] inArrayResult = new double[rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            if ((i-1)%2==0 && (j-1)%2==0) inArray[i,j] = Math.Pow(inArray[i,j],2);
        }
    }
    return inArray;
}