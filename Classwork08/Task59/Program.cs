// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

using static System.Console;
Clear();

int[,] InitArray = GetMatrixArray(5, 5, 1, 20);
PrintMatrixArray(InitArray);
WriteLine($"Наименьший элемент в массиве: {MinNumber(InitArray)}");

int iMin = 0;
int jMin = 0;

for (int i = 0; i < InitArray.GetLength(0); i++)
{
    for (int j = 0; j < InitArray.GetLength(1); j++)
    {
        if (InitArray[i, j] < InitArray[iMin, jMin])
        {
            iMin = i;
            jMin = j;
        }
    }
}
Write($"[{iMin},{jMin}]");
WriteLine();
int[,] ArrayWithoutSmalliestElement = DelRowAnDColomn(InitArray,iMin,jMin);
PrintMatrixArray(ArrayWithoutSmalliestElement);





////////////////////////////////////////////Mehtods/////////////////////////////////////////////
// Метод убирающий строку и строку по заданному элементу

int[,] DelRowAnDColomn(int[,] inArray, int rowToDel, int colomnToDel)
{
    int[,] resultArray = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int newi = 0;
    int newj = 0;
for (int i = 0; i < inArray.GetLength(0)-1; i++)
{
    for (int j = 0; j <inArray.GetLength(1)-1; j++)
    {
        if(j < colomnToDel)
        {
            newj = j;
        }
        else
        {
            newj = j+1;
        }

        if(i < rowToDel)
        {
            newi = i;
        }
        else
        {
            newi = i+1;
        }
        resultArray[i,j]=inArray[newi,newj];
    }
}
return resultArray;
}

// // Метод, который ищет наименьший элемент в массиве

int MinNumber(int[,] inArray)
{
    int minNumberResult = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < minNumberResult) minNumberResult = inArray[i, j];
        }
    }
    return minNumberResult;
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

// //Метод, который выводит на печать одномерный массив
// void PrintArray(int[] inArray)
// {
//     Write("[");
//     for (int i = 0; i < inArray.Length - 1; i++)
//     {
//         Write($"{inArray[i]}, ");
//     }
//     Write($"{inArray[inArray.Length - 1]}]");
// }