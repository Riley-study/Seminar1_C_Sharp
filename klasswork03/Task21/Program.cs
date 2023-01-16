// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

using static System.Console;
Clear();
WriteLine("Input number: ");
int number = int.Parse(ReadLine()!);

int sum = GetSumm(number);
WriteLine($"Sum number 1...A = {sum}");

int GetSumm(int A)
{
    int result = 0;
    while (A>0)
    {
        result+=A;
        A--;
    }
    return result;
}