//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using static System.Console;
WriteLine("Введите первое число: ");
int first = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int second = Convert.ToInt32(ReadLine());
WriteLine("Введите третье число: ");
int therd = Convert.ToInt32(ReadLine());
int max = first;

if (max < second) max = second;
if (max < therd) max = therd;
else max = first;
 WriteLine($"max = {max}");