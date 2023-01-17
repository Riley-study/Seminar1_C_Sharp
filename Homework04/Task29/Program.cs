// Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
Clear();

int[] PrintNewArray = FullArray(8);
PrintArray(PrintNewArray);



//Создаем метод, который создает и заполняет массив случайными числами
int[] FullArray(int size)
{
    int[] res = new int[size];
    for(int i=0; i<res.Length;i++)
    {
        res[i] = new Random().Next(0,10);
    }

    return res;
}

// Создаем метод, который печатает в терминале масив любого размера
void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        Write($"{arr[i]}");
    }
}
