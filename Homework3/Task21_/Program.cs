// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using static System.Console;
Clear();
WriteLine("Введите координату х для точки А");
int Ax = Convert.ToInt32(ReadLine());
WriteLine("Введите координату y для точки А");
int Ay = Convert.ToInt32(ReadLine());
WriteLine("Введите координату z для точки А");
int Az = Convert.ToInt32(ReadLine());
WriteLine("Введите координату х для точки B");
int Bx = Convert.ToInt32(ReadLine());
WriteLine("Введите координату y для точки B");
int By = Convert.ToInt32(ReadLine());
WriteLine("Введите координату z для точки B");
int Bz = Convert.ToInt32(ReadLine());
double length = Math.Sqrt(Math.Pow((Ax-Bx),2)+Math.Pow((Ay-By),2)+Math.Pow((Az-Bz),2));
WriteLine($"Расстояние между двумя точками: {length:f2}");
