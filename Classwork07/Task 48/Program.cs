// **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


using static System.Console;
Clear();

WriteLine("Введите размерность матрицы через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] newArray = GetMatrixArrray(int.Parse(parametrs[0]), int.Parse(parametrs[1]));
PrintMatrixArray(newArray);


//Метод, формирующий массив Aₘₙ = m+n, где m и n размер массива

int[,] GetMatrixArrray(int rows, int colomns)
{
     int[,] resultArray = new int[rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            resultArray[i, j] = i+j;
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