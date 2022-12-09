/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNamber(string massege)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(massege);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 0)
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

void PrintSquare(int namber)
{
    for(int i = 1; i <= namber; i++)
        Console.Write($"{Math.Pow(i, 3)}, ");
}

int namber = GetNamber("Введите число ");

PrintSquare(namber);