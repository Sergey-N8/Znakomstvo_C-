/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNamber(string namberStr)
{
    Console.WriteLine(namberStr);
    int namber = int.Parse(Console.ReadLine() ??"");
    return namber;
}

int SecondNamber(int namber)
{
    int namberSec = (namber / 10) % 10;
    return namberSec;
}

int namber = GetNamber($"Введите трехзначное число: ");

Console.WriteLine($"Втарая цыфра трёхзначного числа {namber} = {SecondNamber(namber)}");