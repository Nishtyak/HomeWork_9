﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = EnterNumberInt("Введите m: ");
int n = EnterNumberInt("Введите n: ");
Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {Ackerman(m, n)}");

int EnterNumberInt(string message)
{
    int num = 0;
    Console.Write(message);
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

int Ackerman(int m, int n)
{
    if(m == 0)
        return n + 1;
    if(n == 0)
        return Ackerman(m - 1, 1);
    return Ackerman(m - 1, Ackerman(m, n - 1));
}