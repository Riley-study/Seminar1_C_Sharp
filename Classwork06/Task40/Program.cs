// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

using static System.Console;
Clear();

// Треугольник со сторонами А В С, длинна сторон задается пользователем

WriteLine("Введите длинну стороны А");
int A = Convert.ToInt32(ReadLine());
WriteLine("Введите длинну стороны B");
int B = Convert.ToInt32(ReadLine());
WriteLine("Введите длинну стороны C");
int C = Convert.ToInt32(ReadLine());

WriteLine(ItIsTriangle(A,B,C)? $"Треугольник со сторонами {A}, {B} и {C} существует":"Треугольник со сторонами {A}, {B} и {C} не существует" );

// Метод, который проверят возможность существования треугольника с заданными сторонами
bool ItIsTriangle(int a, int b, int c)
{
    if(a<(b+c) && b<(a+c) && c<(a+b)) return true;
    return false;
}