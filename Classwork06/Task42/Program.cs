// **Задача 42:** Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.

using static System.Console;
Clear();

WriteLine("Введите число для перевода в двоичную систему счисления");
int InitNumerToConvert = Convert.ToInt32(ReadLine());
WriteLine($"Десятичное число {InitNumerToConvert} в двоичной системе равно {DectimalToBinary(InitNumerToConvert)}.");

// Способ 1 (считаем остаток от деления, переводим в текст, записываем задом на перед):
// Метод, который переводит из 10ой системы счисления в двоичную
// метод текстовый
string DectimalToBinary(int inNum)
{
   // проверка на нулевое значение
    if(inNum==0) return "0";
    // создаем пустую текстовую переменную
    string result = string.Empty;
    // переменная, которая будет хранить остаток от деления rem (remainder)
    int rem;
    while (inNum>0)
    {
        rem = inNum%2;
        inNum/=2;
        // в текстовую переменную result сохраняем в обратном порядке остатки от деления (остаток
        // от деления переводим в текст, затем добавляем то, что уже было в переменной, то есть записываем задом на перед)
        result = rem.ToString()+result;
    }
    return result;

}





// int [] BinaryNumber = BinarySystem(InitNumerToConvert);

// while(InitNumerToConvert>0.5) 
// {
//    int i = InitNumerToConvert%2;
//    InitNumerToConvert=(InitNumerToConvert-i)/2;
//    Write($"{i} ");
// }
// string[] BinaryArrayFromConsole = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// WriteLine(BinaryArrayFromConsole);

// ReverseArray2(BinaryArrayFromConsole);
// PrintArray(BinaryArrayFromConsole);

// // Метод, который переводит число в двоичную систему
// int[] BinarySystem(int NumberToConvert)
// {
//     int[] BinaryArray = new int[10];
//     int i = 0;
//     while (NumberToConvert%10>0.1) 
//     {
//         BinaryArray[i] = NumberToConvert%2;
//         NumberToConvert=NumberToConvert/10;
//         i++;
//     }
//         return BinaryArray;
// }


// // Метод, который разворачивает массив через временную переменную
// void ReverseArray2(int[] inArray)
// {
// for (int i = 0; i < inArray.Length/2; i++)
// {
// int temp = inArray[i];
// inArray[i] = inArray[inArray.Length - 1 - i];
// inArray[inArray.Length - 1 - i] = temp;
// }
// }


// //Метод, который выводит на печать массив
// void PrintArray(int[] inArray)
// {
//     Write("[");
//     for (int i = 0; i < inArray.Length - 1; i++)
//     {
//         Write($"{inArray[i]}, ");
//     }
//     Write($"{inArray[inArray.Length - 1]}]");
// }
