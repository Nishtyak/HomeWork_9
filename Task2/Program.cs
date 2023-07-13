// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = EnterNumberInt("Введите меньшее число: ");
int n = EnterNumberInt("Введите большее число: ");
Console.WriteLine($"M = {m}; N = {n} -> {Sum(m, n)}");

int EnterNumberInt(string message)
{
    int num = 0;
    Console.Write(message);
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

int Sum(int m, int n)
{
    if(m == n)
    {
        return m;
    }
    return Sum(m + 1, n) + m;
}
