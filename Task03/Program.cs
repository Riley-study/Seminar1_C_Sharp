using static System.Console;
WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(ReadLine());
if (a == 1) WriteLine("Понедельник");
if (a == 2) WriteLine("Вторник");
if (a == 3) WriteLine("Среда");
if (a == 4) WriteLine("Четверг");
if (a == 5) WriteLine("Пятница");
if (a == 6) WriteLine("Суббота");
if (a == 7) WriteLine("Воскресенье");
else WriteLine("Введено неверное число");
