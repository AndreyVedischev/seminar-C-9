using System;
using static System.Console;
Clear();

WriteLine(GetNumbers(6, 3));

// string GetNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     if (start < end) return $"{start} {GetNumbers(start + 1, end)}";
//     else
//     {
//         return $"{end} {GetNumbers(end + 1, start)}";
//     }    
// }
string GetNumbers(int start, int end)
{
    return start==end?start.ToString()
    :start<end?$"{start} {GetNumbers(start + 1, end)}"
    :$"{end} {GetNumbers(end + 1, start)}";
}