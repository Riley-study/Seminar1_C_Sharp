// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

using static System.Console;
Clear();

Write("Ведите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

WriteLine($"[{String.Join(",", array)}]");
ReverseArray2(array);
WriteLine($"[{String.Join(",", array)}]");
//WriteLine($"[{String.Join(",", ReverseArray1(array))}]");

// Метод, который создает массив и заполняет его случайными числами от 1 до 10

int[] GetArray(int size)
{
int[] resultArray = new int[size];
for (int i = 0; i < size; i++)
{
resultArray[i] = new Random().Next(1, 10);
}
return resultArray;
}

// Метод, который разворачивает массив Способ 1 создаем новый массив, в котором через соответствующие индексы менем местами элементы массива
int[] ReverseArray1(int[] inArray)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length - 1 - i];
}
return result;
}

// Метод, который разворачивает массив Способ 2 через временную переменную
void ReverseArray2(int[] inArray)
{
for (int i = 0; i < inArray.Length/2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - 1 - i];
inArray[inArray.Length - 1 - i] = temp;
}
}