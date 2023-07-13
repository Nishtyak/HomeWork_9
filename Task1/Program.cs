// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = EnterNumberInt("Введите число: ");
Console.WriteLine(OutputN(n));
Console.WriteLine(OutputNEven(n));

int EnterNumberInt(string message)
{
    int num = 0;
    Console.Write(message);
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

string OutputN (int n)
{
    if(n == 1)
    {
        return "1";
    }
    return  n.ToString()  + ", " + OutputN(n - 1);
}

string OutputNEven (int n)
{
    //string result;
    if(n == 2)
    {
        return "2";
    }
    if(n % 2 == 1)
    {
        n -= 1;
    }
    if(n < 2)
    {
        return "---";
    }
    return  n.ToString()  + ", " + OutputNEven(n - 2);
}