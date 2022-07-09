using System;
using static System.Console;
Clear();

WriteLine("Введите число A: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число B: ");
int b = Convert.ToInt32(ReadLine());
WriteLine(MultiNumbers(a, b));

int MultiNumbers(int n, int m)
{
    return m > 0 ? n * MultiNumbers(n, --m) : 1;
    // int pov = 0;
    // if(m > 0)
    // {
    //     return pov = n*MultiNumbers(n,--m);

    // }
    // else return 1;
}
