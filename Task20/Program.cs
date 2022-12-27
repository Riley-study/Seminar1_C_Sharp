// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
using static System.Console;
Clear();
WriteLine("Введите число N: ");
int N = Convert.ToInt32(ReadLine());
int number = 1;
while (Math.Pow(number,2)<N) 
{
Write($"{Math.Pow(number,2)};");
number=number+1;
}
