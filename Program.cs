// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Int32.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Int32.Parse(Console.ReadLine());

int SumOfSeries(int m, int n)
{
    if (m == n)
        return n;
    return n + SumOfSeries(m, n - 1);
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {SumOfSeries(m, n)}");