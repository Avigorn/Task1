﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine();
int value = Convert.ToInt32(num);
for (int i = 0; i <= value; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + " ");
    }
}

System.Console.WriteLine();