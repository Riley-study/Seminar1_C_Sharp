//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;
WriteLine("Введите первое число: ");
int first = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int second = Convert.ToInt32(ReadLine());
if (first > second) 
{
WriteLine($"max = {first}");
}
else {
    WriteLine($"max = {second}");
}
