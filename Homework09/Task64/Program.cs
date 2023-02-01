// Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();


PrintNumbers(10);



// Метод, печатающий числа от заданного N до 1

void PrintNumbers(int num)
{
    if (num < 1) Write("Введите натуральное число больше 1");
    else
    {
        if (num == 1) Write(num);
        else
        {
            Write($"{num},");
            PrintNumbers(num - 1);
        }
    }

}