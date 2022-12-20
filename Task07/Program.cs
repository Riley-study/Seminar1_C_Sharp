using static System.Console;
WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(ReadLine());
int last_symbol = a % 10;
WriteLine($"последний символ {last_symbol}");