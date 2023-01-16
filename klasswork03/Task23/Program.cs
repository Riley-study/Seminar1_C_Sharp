// Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120
using static System.Console;
Clear();

WriteLine("Input number N: ");
int number = Convert.ToInt32(ReadLine());

//Обратимся или вызовем метод
int FactorialResult = Factorial(number);
WriteLine($"Factorial N (N!) = {FactorialResult}");

// Напишем метод
int Factorial(int A)
{
    int result = 1;
    while (A>1)
    {
        result*=A;
        A--;
    }
    return result;
}