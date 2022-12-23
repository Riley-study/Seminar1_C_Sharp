// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
using static System.Console;
Clear();
int number = new Random().Next(10,100);
WriteLine(number);
int a1=number/10;
int a2=number%10;
if (a1>a2)
{
    WriteLine(a1);
}
else
{
     WriteLine(a2);
}
// WriteLine(a1>a2?a1:a2); с использоанием тернарного оператора в одну строку!
