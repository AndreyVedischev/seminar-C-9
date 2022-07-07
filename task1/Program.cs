using System;
using static System.Console;
Clear();

WriteLine("Введите число N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите стартовое число: ");
int m = Convert.ToInt32(ReadLine());
if (n < m)
{
    int temp = n;
    n = m;
    m = temp;
}
OutputBeforeN(n, m);

void OutputBeforeN(int a, int start)
{
    if (start <= a)
    {
        Write($"{start} ");
        start++;
        OutputBeforeN(a, start);
    }
    else return;
}