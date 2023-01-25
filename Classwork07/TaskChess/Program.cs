// Какого цвета клетка шахматной доски, если начинается с черной

using static System.Console;
Clear();

WriteLine("Введите номер строки и столбца клетки на шахматной доске через пробел: ");
//Вариант 1 для числового ввода клетки:
// int[] intParams=Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries),int.Parse);
// WriteLine(CellColor(intParams[0], intParams[1])? "черная": "белая");

// Вариант 2 для буквенно-числового ввода клетки
string parametrs = ReadLine();

int par1 = parametrs[0];
int par2 = parametrs[1];
WriteLine(CellColor(par1, par2)? "черная": "белая");




// Метод, возвращающий цвет клетки на шахматной доске:
bool CellColor(int a, int b)
{
if ((a+b)%2==0) return true;
return false;
}



// Для проверки правельного формирования шахматной доски
//int[,] ChessTable = GetChessMatrix(10,10);
//PrintMatrixArray(ChessTable);

// // Метод,который формирует двумерный массив 10/10 заполненный поочередно 0 и 1 (где 0 - белый, 1 - черный)
// int[,] GetChessMatrix(int rows, int colomns)
// {
//     int[,] resultArray = new int[rows, colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             resultArray[0, 0] = 1;
//             if ((i+j)%2==0) resultArray[i, j] = 1;
//             else resultArray[i, j] = 0;
//         }
//     }
//     return resultArray;

// }

// // Метод, выводящий массив на печать
// void PrintMatrixArray(int [,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j],3}");
//         }
//         WriteLine();
//     }
// }
