// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10

using static System.Console;
Clear();

WriteLine("Input number: ");
int number = int.Parse(ReadLine()!);
int CountSumOfNumbersPrint = CountSumOfNumbers(number);
WriteLine($"Result: {CountSumOfNumbersPrint}");

// Метод, рассчитывающий сумму цифр в числе
int CountSumOfNumbers(int A)
{
    int result = 0;
    while(A>=1)
    {
        A=A/10;
        result+=A%10;
    }
    return result;
}
