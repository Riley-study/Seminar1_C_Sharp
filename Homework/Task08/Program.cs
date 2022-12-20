// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1
using static System.Console;
WriteLine("Введите число: ");
int n = Convert.ToInt32(ReadLine());
int number = 2;
while (number<=n) {Write($"{number} ");
number = number + 2;
}
