﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int M = Convert.ToInt32(Console.ReadLine());

static int AccK(int N, int M)
{
    if (N == 0)
    return M + 1;
    
    if (M == 0) return AccK(N-1, 1);
        else
            return AccK(N - 1, AccK(N, M - 1));
}

Console.WriteLine($"Функция Аккермана от этих чисел {AccK(N,M)} ");