// Задача 2: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int AkkermanFunctionCalculation(int m, int n) // Вычисление функции Аккермана
{
    if (m == 0) 
    {
    return n + 1;
    }
    else if (m > 0 && n == 0) 
    {
    return AkkermanFunctionCalculation(m - 1, 1);
    }
    else 
    {
    return AkkermanFunctionCalculation(m - 1, AkkermanFunctionCalculation(m, n - 1));
    }
}


Console.Write("Введите первое неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.Write("Необходимо ввести неотрицательные числа!");
}
else
{
Console.Write(AkkermanFunctionCalculation(m, n));
}
