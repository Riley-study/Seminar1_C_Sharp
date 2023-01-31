// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;
Clear();

PrintNumbersRecurs(10,15);
WriteLine();
Write(GetNumbers(20,10));





////////////////////////////
void PrintNumbersRecurs(int minValue, int maxValue)
{
if(minValue>maxValue) 
{
    int temp = minValue;
    minValue=maxValue;
    maxValue=temp;
}

if (minValue==maxValue) 
{
    Write($"{maxValue}");
}
else
{
PrintNumbersRecurs(minValue+1, maxValue);
Write($",{minValue}");
}
}


////////////////////////////////

string GetNumbers(int minValue, int maxValue)
{
if(minValue>maxValue) 
{
    int temp = minValue;
    minValue=maxValue;
    maxValue=temp;
}
if (minValue == maxValue) return maxValue.ToString();
else return $"{GetNumbers((minValue + 1), maxValue)},{minValue}";
}