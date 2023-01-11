
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
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

///Метод вычисления функции Аккермана:
int GetAckerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }

    else if (numberM != 0 && numberN == 0)
    {
        return GetAckerman(numberM - 1, 1);
    }

    else if (numberM > 0 && numberN > 0)
    {
        return GetAckerman(numberM - 1, GetAckerman(numberM, numberN - 1));
    }
    return GetAckerman(numberM, numberN);
}

int numberM = GetNumber($"Введите первое натуральное, неотрицательное число");

int numberN = GetNumber($"Введите втрое натуральное, неотрицательное число");

Console.WriteLine($"A({numberM},{numberN}) = {GetAckerman(numberM, numberN)}");
