// Напишите программу, которая принимает на вход число (А) и выдаёт сумму 
//чисел от 1 до А, на которые А делится без остатка

using static System.Console;
Clear();
WriteLine("Input number: ");
int number = int.Parse(ReadLine()!);

int sum = GetSumm(number);
WriteLine($"Sum divider of A = {sum}");

int GetSumm(int A)
{
    int result = 0;
    int del = 1;
    while (del<=A)
    {
        if (A%del==0)
        {
            result+=del;
        }
        else result=result+0;
        del++;
    }
    return result;
}