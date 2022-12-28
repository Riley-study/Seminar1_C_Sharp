// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
using static System.Console;
Clear();
WriteLine("Введите число: ");
int N = Convert.ToInt32(ReadLine());
int cube = 1;
while (cube<N) 
{
WriteLine($"Куб числа {cube} равен: {cube*cube*cube}");
cube++;
}

