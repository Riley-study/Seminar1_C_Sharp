// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();

int[,,] InitMatrix = GetMatrixArray3(2,2,2,10,99);
PrintMatrixArray3(InitMatrix);







//////////////////////////////////////////////// Methods ////////////////////////////////////////////////////

// Метод, 

//Метод, формирующий трехмерную матрицу заданного размера в заданном диапозоне
int[,,] GetMatrixArray3(int rows, int colomns, int weight, int minValue, int maxValue)
{
    int[,,] resultArray = new int[rows, colomns, weight];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
           for (int z = 0; z < weight; z++)
           {
             resultArray[i, j, z] = rnd.Next(minValue, maxValue + 1);
           }
           
        }
    }
    return resultArray;
}

// Метод, выводящий трехмерную матрицу на печать
void PrintMatrixArray3(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           for (int z = 0; z < inArray.GetLength(2); z++)
           {
            Write($"{inArray[i, j,z],5} ({i},{j},{z})");
           }
            
        }
        WriteLine();
    }
}
