// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
using static System.Console;
Clear();

WriteLine("Введите координату х точки А: ");
int Ax = Convert.ToInt32(ReadLine());
WriteLine("Введите координату y точки А: ");
int Ay = Convert.ToInt32(ReadLine());
WriteLine("Введите координату х точки B: ");
int Bx = Convert.ToInt32(ReadLine());
WriteLine("Введите координату y точки B: ");
int By = Convert.ToInt32(ReadLine());
double Length = Math.Sqrt(Math.Pow((Bx - Ax),2) + Math.Pow((By - Bx),2));
WriteLine($"Длинна отрезка АВ : {Length:f2}");
