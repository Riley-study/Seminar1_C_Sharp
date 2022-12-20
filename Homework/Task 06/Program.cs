// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
using static System.Console;
WriteLine("Введите число: ");
int a = Convert.ToInt32(ReadLine());
int number = a % 2;
if (number == 0) WriteLine($"Число {a} четное");
else WriteLine($"Число {a} не четное");