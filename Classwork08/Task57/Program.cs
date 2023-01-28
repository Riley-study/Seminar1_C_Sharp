// **Задача 57:** Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


using static System.Console;
Clear();

WriteLine("Введите размер массива и интервал значений через пробел");
string [] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] InitArray = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[2]), int.Parse(parametrs[3]));
PrintMatrixArray(InitArray);

int[] dict = new int[int.Parse(parametrs[3])-int.Parse(parametrs[2])];
for (int k = 0; k < dict.Length; k++)
{
    for (int i = 0; i < InitArray.GetLength(0); i++)
    {
        for (int j = 0; j < InitArray.GetLength(1); j++)
        {
           if(InitArray[i,j]==k+int.Parse(parametrs[2]))
           {
            dict[k]++;
           }
        }
    }
}

for (int k = 0; k < dict.Length; k++)
{
    WriteLine($"{k+int.Parse(parametrs[2])} встречается {dict[k]} раз");
}










////////////////////////////////////////Methods////////////////////////////////////////////
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