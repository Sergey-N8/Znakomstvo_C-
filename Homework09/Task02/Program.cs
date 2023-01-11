
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return result;
}

int GetSumMN(int m, int n, int summ)
{
    if (m == n && summ == 0)
    {
        return summ;
    }
    else if (m > n)
    {
        return summ;
    }
    else
    {
        summ += n;
        return GetSumMN(m, n - 1, summ);
    }
}

int m = GetNumber($"Введите натуральное число от которого вы хотите посчитать сумму");

int n = GetNumber($"Введите натуральное число до которого вы хотите посчитать сумму");

int summ = 0;

Console.WriteLine(GetSumMN(m, n, summ));
