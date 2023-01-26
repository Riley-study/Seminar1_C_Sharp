// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в 
//двумерном массиве, и возвращающий значение этого элемента или же указание, что такого 
//элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9


using static System.Console;
Clear();

WriteLine("Введите позицию искомого элемента в массиве в формате n;m:");

int[] intParams=Array.ConvertAll(ReadLine()!.Split(";",StringSplitOptions.RemoveEmptyEntries),int.Parse);

int par1 = intParams[0];
int par2 = intParams[1];
//для проверки
//WriteLine($"{par1}, {par2}");

int[,] InitArray = GetMatrixArrray(5,5,1,30);
PrintMatrixArray(InitArray);

WriteLine(par1>=InitArray.GetLength(0)? "такого элемента в массиве нет": par2>=InitArray.GetLength(1)? "такого элемента в массиве нет": FoundNumber(InitArray, par1, par2));    





// Метод, который выводит нужный элемент из массива
int FoundNumber(int[,] inArray, int rowsFound, int colomnsFound)
{
    int result = inArray[rowsFound,colomnsFound];
    return result;
}


//Метод, формирующий массив с заданным размером и диапозоном

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