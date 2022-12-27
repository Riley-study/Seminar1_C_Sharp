// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
using static System.Console;
Clear();
WriteLine("Введите число N: ");
int N = Convert.ToInt32(ReadLine());
int number = 1;
while (Math.Sqrt(number)<N) 
{
WriteLine(Math.Sqrt(number));
number=number+1;
}
