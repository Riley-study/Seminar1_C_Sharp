using static System.Console;
WriteLine("Введите число: ");
int a = Convert.ToInt32(ReadLine());
int N = -a;
while (N <= a) {
    Write($"{N},");
    N = N+1;
}


