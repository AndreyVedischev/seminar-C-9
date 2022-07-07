using System;
using static System.Console;
Clear();

WriteLine("Введите число N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите стартовое число: ");
int m = Convert.ToInt32(ReadLine());
OutputBeforeN(n, m);

void OutputBeforeN(int a, int start)
{
    if (a > start)
    {
        if (start <= a)
        {
            Write($"{start} ");
            start++;
            OutputBeforeN(a, start);
        }
        else return;
    }
    
    // else
    // if (a < start)
    // {
    //     int temp = a;
    //     a = start;
    //     start = temp;
    //     OutputBeforeN(a, start);
    // }
    // return;
    
}
