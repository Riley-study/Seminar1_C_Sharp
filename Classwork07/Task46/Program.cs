// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными 
// целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


using static System.Console;
Clear();

Write("Введите диапазон матрицы и диапазон значений через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArrray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[2]), int.Parse(parametrs[3]));
PrintMatrixArray(array);

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