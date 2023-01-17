// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10

using static System.Console;
Clear();

// Получение данных от пользователя
WriteLine("введите целое число: ");
int number = int.Parse(ReadLine()!);
// Использование метода, рассчитывающего сумму цифр в числе
int CountSumOfNumbersPrint = CountSumOfNumbers(number);
WriteLine($"Result: {CountSumOfNumbersPrint}");

// Метод, рассчитывающий сумму цифр в числе
int CountSumOfNumbers(int A)
{
    int result = 0;
    if (A<0)
    {
        A=-A;
    }
    while(A>=1)
    {
        result+=A%10;
        A=A/10;
    }
    return result;
}
