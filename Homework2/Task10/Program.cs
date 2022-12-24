// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
using static System.Console;
WriteLine("Введите трехзначное число");
int number=Convert.ToInt32(ReadLine());
WriteLine(number/10%10);