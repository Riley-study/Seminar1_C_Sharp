// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

Write(PrintSumNumbers(1,15));




////////////////////////////    Methods    /////////////////////////////////////
// Метод, который находит сумму натуральных элементов в промежутке от M до N (рекурсивно)

int PrintSumNumbers(int minValue, int maxValue)
{
    int sum = 0;
    if (minValue > maxValue)
    {
        int temp = minValue;
        minValue = maxValue;
        maxValue = temp;
    }
    
    if (minValue == maxValue)
    {
        sum+=sum + maxValue;
    }
    else
    {
        sum += minValue+PrintSumNumbers(minValue + 1, maxValue);
        
    }
    return sum;
}
