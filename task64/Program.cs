using System;
using static System.Console;
// task 64 Задайте числа М и Н. Напишите программу, которая выведет все
// натуральные числа по убыванию в промежутке от М до Н.
Clear();
Write("Введите число M ");
int m = int.Parse(ReadLine());
Write("Введите число N ");
int n = int.Parse(ReadLine());
WriteLine(RowNumber(m, n));


string RowNumber(int m, int n)
{
    if (m == n) return m.ToString();
    return(n + " " + RowNumber(m,n-1));
    
}

