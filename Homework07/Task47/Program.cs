// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
Clear();

WriteLine("Введите размер матрицы и диапозон значений через пробел");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double [,] InitArray = GetMatrixArrray(int.Parse(parametrs[0]), int.Parse(parametrs[1]),int.Parse(parametrs[2]),int.Parse(parametrs[3]));
WriteLine("Итоговый массив:");
PrintMatrixArray(InitArray);

// Метод,который формирует двумерный массив с указанным кол-ом строк и столбцов и 
//заполняет его случайными значениями в указанном интервале
double[,] GetMatrixArrray(int rows, int colomns, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] resultArray = new double[rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            double number = rnd.NextDouble()*(maxValue-minValue)+minValue;
            resultArray[i, j] = Math.Round(number,1);
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