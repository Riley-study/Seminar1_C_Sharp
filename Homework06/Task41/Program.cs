// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

Write("Введите числа через пробел: ");
string[] numbers = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] ConvertArrayToInt = Array.ConvertAll(numbers, s => int.Parse(s));
PrintArray(ConvertArrayToInt);
WriteLine($" -> {CountNegative(ConvertArrayToInt)}");




// Метод, который считает количество элементов меньше нуля в массиве
int CountNegative(int[] inArray)
{
    int count=0;
    for(int i=0; i<inArray.Length;i++)
    {
        if (inArray[i]<0) count++;
    }
    return count;
} 

//Метод, который выводит на печать массив
void PrintArray(int[] inArray)
{
    Write("[");
    for (int i=0; i< inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
}