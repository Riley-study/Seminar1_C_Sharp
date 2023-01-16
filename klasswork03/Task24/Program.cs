// Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
using static System.Console;
Clear();

int[] BinaryArrayPrint = BinaryArray();
PrintArray(BinaryArrayPrint);
WriteLine();
int[] BinaryArrayPrint1 = BinaryArray();
PrintArray(BinaryArrayPrint1);
WriteLine();
int[] BinaryArrayPrint2 = BinaryArray();
PrintArray(BinaryArrayPrint2);
WriteLine();
int[] BinaryArrayPrint3 = BinaryArray();
PrintArray(BinaryArrayPrint3);
WriteLine();

//создаем пустой массив с произвольной размерностью, заполняем его произвольными 
//числами или в указанном диапазоне, печатаем массив
int[] CreateEmptyArray = GetArray(10);
ArrayFilling(CreateEmptyArray);
PrintArray(CreateEmptyArray);



//Создаем метод, который заполняет массив из 8 элементов случайными числами от 0 до 1
int[] BinaryArray()
{
    int[] res = new int[8];
    for(int i=0; i<res.Length;i++)
    {
        Random ran = new Random();
        res[i]=ran.Next(2);
    }

    return res;
}

// Создаем метод, который печатает в терминале масив
void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        Write($"{arr[i]}");
    }
}

// Написать метод,который заполняет действующий пустой массив 0 и 1
void ArrayFilling (int[] arr2)
{
    for(int i=0; i<arr2.Length;i++)
    {
        arr2[i] = new Random().Next(0,5);
        
    }
}
// Метод, который создает пустой массив размером size
int[] GetArray (int size)
{
    int[] array = new int[size];
    return array;
}