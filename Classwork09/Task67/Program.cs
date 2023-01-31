// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

using static System.Console;
Clear();

Write($"{SumNumbers(5478)}");



///////////////////////Methods//////////////////////

int SumNumbers(int num)
{
    int sum = 0;
    if (num == 0) return sum;
    else
    {
sum = num%10 + SumNumbers(num/10);
    }
return sum;

}
