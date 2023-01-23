// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

WriteLine("Введите значения k1: ");
double Init_k1 = Convert.ToDouble(ReadLine());
WriteLine("Введите значения b1: ");
double Init_b1 = Convert.ToDouble(ReadLine());
WriteLine("Введите значения k2: ");
double Init_k2 = Convert.ToDouble(ReadLine());
WriteLine("Введите значения b2: ");
double Init_b2 = Convert.ToDouble(ReadLine());


double CoordinateX = FindX(Init_k1,Init_k2,Init_b1,Init_b2);
double CoordinateY = Init_k1*CoordinateX+Init_b1;

WriteLine(Init_k1==Init_k2? "Графики функций параллельны друг другу": "Графики фукций пересекаются в точке:");
WriteLine($"({CoordinateX};{CoordinateY})");

// Метод, который находит координату Х точки пересечения двух прямых
double FindX (double k1, double k2, double b1, double b2)
{
    double result = (b2-b1)/(k1-k2);
    return result;
}
