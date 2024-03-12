// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Clear();

void OutputNaturalNumbers(int m, int n)
{
    if (n == m - 1)
    {
        return;
    }
    OutputNaturalNumbers(m, n - 1);
    Console.Write(n+" ");
}

Console.Write("Введите минимальное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int n = Convert.ToInt32(Console.ReadLine());
OutputNaturalNumbers(m, n);
