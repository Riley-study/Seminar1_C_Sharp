// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
using static System.Console;
Clear();
WriteLine("Введите количество членов последовательности Фибонатччи: ");
int Fibonatcci = Convert.ToInt32(ReadLine());
// Write(FibonatcciMethod(Fibonatcci));

//Вариант 1: через запись элементов в строке (как текст)
//Метод, формирующий последовательность Фибонатччи 0,1,1,2, 3, 5,8 и тд.
// string FibonatcciMethod(int inNum)
// {
//     if (inNum <= 1) return "0";
//     string result = "0";
//     int i = 3;
//     int FirstNum = 0;
//     int SecondNum = 1;
//     while (i <= inNum+1)
//     {
//         int NextNum = FirstNum + SecondNum;
//         result = result + ", " + SecondNum.ToString();
//         FirstNum = SecondNum;
//         SecondNum = NextNum;
//         i++;

//     }

//     return result;
// }

// Вариант 2 чисто математический
// WriteLine("Введите число");
// int number = int.Parse(ReadLine()!);
// FibonatcciMath(number);

// //Метод, формирующий последовательность Фибонатччи математическим способом
// void FibonatcciMath(int inNum) 
// {
//     int temp, num1 = 0, num2 = 1;
//     //if (a<2) return 0;
//     Write($"{num1}, {num2}");
//     for (int i = 2; i < inNum; i++)
//     {
//         temp = num1 + num2;
//         num1 = num2;
//         num2 = temp;

//         Write($", {num2}");
//     }
// }



// Вариант 3: через вывод массива (самый красивый!!!!)
int[] FibonatcciArray = Fibonatcci2(Fibonatcci);
PrintArray(FibonatcciArray);

int[] Fibonatcci2(int inNum)
{
    int[] result = new int[inNum];
    result[0] =0;
    result[1]=1;
    for(int i=2; i<inNum;i++)
    {
result[i]=result[i-1]+result[i-2];
    }
    return result;
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