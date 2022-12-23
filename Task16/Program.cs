// **Задача 16:** Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
using static System.Console;
WriteLine("Введите число: ");
int number1 = Convert.ToInt32(ReadLine());
WriteLine("Введите число: ");
int number2 = Convert.ToInt32(ReadLine());

WriteLine(number1*number1==number2? "Второе число является квадратом первого": number2*number2==number1? "Первое число является квадратом второго":"Не является");
