// Задача 52. Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();

double[,] AverageMatrix = GetMatrixArrray(4, 8, 1, 5);
PrintMatrixArray(AverageMatrix);
//double[] resultMtrx = AverageColumns(AverageMatrix);
PrintArray(AverageColumns(AverageMatrix));





//Метод, рассчитывающий среднеарифметическое значение каждого столбца
double[] AverageColumns(double[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum = sum + inArray[i, j];
        }
        double sumAverege = Math.Round(sum / inArray.GetLength(0), 1);
        result[j] = sumAverege;
    }
    return result;
}

//Метод, формирующий массив с заданным размером и диапозоном

double[,] GetMatrixArrray(int rows, int colomns, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] resultArray = new double[rows, colomns];
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
void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3}");
        }
        WriteLine();
    }
}

// Метод, выводящий одномерный массив на печать
void PrintArray(double[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}