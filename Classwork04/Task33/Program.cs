// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует 
//ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

using static System.Console;
Clear();

WriteLine("Введите чило, которое необходимо найти в массиве");
int FoundNumber = Convert.ToInt32(ReadLine());

int[] SearchingArray = {-6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6};
PrintArray(SearchingArray);
WriteLine();
WriteLine($"{FoundNumber}  -> ");
WriteLine(SearchingNumber(SearchingArray, FoundNumber)? "да": "нет");
// матод, который проверяет массив на присутствие заданного числа в этом массиве

bool SearchingNumber(int[] inArray, int number)
{
    foreach(int i in inArray)
    {
        if (i==number) return true;
    }
    return false;
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