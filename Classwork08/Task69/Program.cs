// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8


using static System.Console;
Clear();

WriteLine(DegreeNumber(3,3));






//////////////////// Methods ////////////////////////

int DegreeNumber(int first, int second)
{
    int degreeResult = 1;
    if (second == 0) return degreeResult;

    degreeResult = first * DegreeNumber(first, second - 1);

    return degreeResult;
}