﻿string[] array1 = {"hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
string[] array4 = {"Ru", "Den4", "Su"};

void PrintStringArray(string[] array)
{
    int length = array.Length;
    string result = String.Empty;
    for (int i = 0; i < length; i++)
        {
            result = result + array[i] + ", ";
        }
    if (result.Length > 1) result = result.Substring(0, result.Length - 2);
    Console.Write("[" + result + "]");
}

