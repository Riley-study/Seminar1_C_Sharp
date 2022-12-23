// **Задача 11:** Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
using static System.Console;
Clear();
int number = new Random().Next(100,1000);
WriteLine(number);
int a1 = number/100;
int a2 = number/10;
int a3 = number%10;
WriteLine(a1*10+a3);
