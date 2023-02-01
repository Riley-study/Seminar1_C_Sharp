// Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// ack 0 n = n+1
// ack n 0 = ack (n-1) 1
// ack n m = ack (n-1) (ack n (m-1))

using static System.Console;
Clear();

Write($"Значение функции Аккермана :{Akkerman(3,2)}");



// Метод, реализующий вычисление функции Аккермана с помощью рекурсии

int Akkerman(int firstNumber, int secondNumber)
{
    int result= 0;
    if (firstNumber == 0) result = secondNumber + 1;
    else
    {
        if (secondNumber == 0) result = Akkerman(firstNumber - 1, 1);
        else
        {
result = Akkerman(firstNumber-1, Akkerman(firstNumber, secondNumber-1));
        }
    }
    return result;
}