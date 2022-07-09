using System;
using static System.Console;
Clear();

WriteLine("Введите число N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine(SumNumbers(n));

int SumNumbers(int a)
{
    int sum = 0;
    if(a>0)
    {
        sum = a%10 + SumNumbers(a/10);   
                        
    }
    return sum;    
}