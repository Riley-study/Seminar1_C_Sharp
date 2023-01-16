// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
using static System.Console;
Clear();


WriteLine("Input number: ");
int number = int.Parse(ReadLine()!);
int CountNumberPrint = CountNumber(number);
WriteLine($"Result: {CountNumberPrint}");

// напишем метод
int CountNumber(int A)
{
    int result = 0;
    while(A>=1)
    {
        A=A/10;
        result+=1;
    }
    return result;
}
