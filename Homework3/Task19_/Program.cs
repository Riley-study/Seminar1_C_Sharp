// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();
WriteLine("Введите пятизначное число: ");
int polindrom = Convert.ToInt32(ReadLine());
int first = polindrom%10;
int second = polindrom/10%10;
int fourth = polindrom/1000%10;
int fifth = polindrom/10000%10;
WriteLine(first==fifth && second==fourth? "Да":"Нет");