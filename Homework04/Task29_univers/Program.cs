// Напишите программу, реализующую метод, который формирует массив случайных целых чисел в заданном диапозоне 
// из заданного количества элементов и выводит их на экран.

using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
int ArraySize = int.Parse(ReadLine()!);
WriteLine("Введите минимальное значение диапазона (A): ");
int numberA = int.Parse(ReadLine()!);
WriteLine("Введите максимальное значение диапазона (В): ");
int numberB = int.Parse(ReadLine()!);

int[] PrintNewArray = FullArray(ArraySize, numberA, numberB);
PrintArray(PrintNewArray);


//Создаем метод, который создает и заполняет массив размером size случайными числами в диапозоне от А до В
int[] FullArray(int size, int A, int B)
{
    int[] res = new int[size];
    for(int i=0; i<res.Length;i++)
    {
        res[i] = new Random().Next(A, B+1);
    }

    return res;
}

// Создаем метод, который печатает в терминале масив любого размера в формате [ , , , ]
void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        Write(i==0? $"[{arr[i]}, ":i==arr.Length-1? $"{arr[i]}]": $"{arr[i]}, ");
    }
}

