// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
//третьей цифры нет.
using static System.Console;
WriteLine("Введите число");
int number=Convert.ToInt32(ReadLine());
WriteLine(number>99? number/100%10:"Третьей цифры нет");
