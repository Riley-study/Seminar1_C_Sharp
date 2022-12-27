// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
using static System.Console;
Clear();
WriteLine("Введите число N: ");
//int N = Convert.ToInt32(ReadLine());
int.TryParse(ReadLine(), out int N);
int number = 1;
while (number<N) 
{
WriteLine($"Квадрат числа {number} = {Math.Pow(number,2)};");
number=number+1;
}
