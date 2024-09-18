using System;
using static System.Console;
// task 64 Задайте числа М и Н. Напишите программу, которая найдет сумму
// натуральных элементов в промежутке от М до Н.
Clear();
Write("Введите число M ");
int m = int.Parse(ReadLine());
Write("Введите число N ");
int n = int.Parse(ReadLine());
if(m<n)
{
    WriteLine(SumRow(m, n));
}
else
{
    WriteLine(SumRow(n, m));
}

int SumRow(int m, int n)
{
    if (m == n) return m;
    return (n + SumRow(m, n - 1));
}