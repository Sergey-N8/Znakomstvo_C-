/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
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

string GetTreNamber(int namber)
{
    int namberTre = namber % 10;
    if(namber < 1000 && namber > 99)
        return $"Третья цифра {namberTre}";
    if(namber > 999)
        while(namberTre > 10)
            namberTre = namberTre / 10;
        return $"Третья цифра {namberTre}";
    return $"Третьей цифры нет";
}

int namber = GetNamber("Введите число ");

Console.WriteLine(GetTreNamber(namber));