using System;
using static System.Console;
Clear();

WriteLine(GetNumbers(5, 2));

string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    if (start < end) return $"{start} {GetNumbers(start + 1, end)}";
    else
    {
        return $"{end} {GetNumbers(end + 1, start)}";
    }    
}