using System;
using static System.Console;
// task 68 Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
Clear();
Write("Введите неотрицательное число M ");
int m = int.Parse(ReadLine());
Write("Введите неотрицательное число N ");
int n = int.Parse(ReadLine());
WriteLine($"Функция Аккермана = {Akkerman(m,n)}");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
