// **Задача 14:** Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
using static System.Console;
int number = Convert.ToInt32(ReadLine());
WriteLine(number%7==0? number%23==0? "Да":"Нет");

