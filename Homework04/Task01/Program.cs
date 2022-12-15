/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNamber(string massege)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(massege);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine($"Введите корректное число");
        }

    }

    return result;
}


void GetNamberPowerOff(int namberFirst, int namberSecond)
{
    int result = namberFirst;
    for(int i = 1; namberSecond > i; i++)

        result = result * namberFirst;

    Console.WriteLine(result);
}

int namberFirst = GetNamber("Введите первое число");
int namberSecond = GetNamber("Введите степень в которую необходимо возвести первое число");

GetNamberPowerOff(namberFirst, namberSecond);