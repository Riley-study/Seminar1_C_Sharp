// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
//В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


using static System.Console;
Clear();
// Получение данных от пользователя
WriteLine("Input number A: ");
int numberA = int.Parse(ReadLine()!);
WriteLine("Input number B: ");
int numberB = int.Parse(ReadLine()!);

// Использование метода, возводящего число А в степень В
int PrintDegreeA = DegreeA(numberA, numberB);
WriteLine($"Число А в степени В равно {PrintDegreeA}");

// Метод, возводящий число А в степень В
int DegreeA(int A, int B)
{
    int result = 1;
    int i = 1;
    while (i<=B)
    {
        result=result*A;
        i++;
    }
    return result;
}