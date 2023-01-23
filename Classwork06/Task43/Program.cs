// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
using static System.Console;
Clear();
WriteLine("Введите количество членов последовательности Фибонатччи: ");
int Fibonatcci = Convert.ToInt32(ReadLine());
Write(FibonatcciMethod(Fibonatcci));

//Метод, формирующий последовательность Фибонатччи 0,1,1,2, 3, 5,8 и тд.
string FibonatcciMethod(int inNum)
{
    if (inNum <=1) return "0";
    if (inNum ==2) return "0, 1";
    string result = "0, 1";
    int i = 3;
    int FirstNum = 0;
    int SecondNum = 1;
    while (i <= inNum)
    {
        int NextNum = FirstNum + SecondNum;
        result = result + ", " + NextNum.ToString();
        FirstNum=SecondNum;
        SecondNum=NextNum;
        i++;

    }

    return result;
}