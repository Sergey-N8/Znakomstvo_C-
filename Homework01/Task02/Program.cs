/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
string namberFirStr = Console.ReadLine();
Console.Write("Введите второе число: ");
string namberSecStr = Console.ReadLine();
Console.Write("Введите третье число: ");
string namberTreStr = Console.ReadLine();

int namberFir = Convert.ToInt32(namberFirStr);
int namberSec = Convert.ToInt32(namberSecStr);
int namberTre = Convert.ToInt32(namberTreStr);

if (namberFir < namberSec)
{
    Console.WriteLine($"max = {namberSec}");
}

else if (namberFir < namberTre)
{
    Console.WriteLine($"max = {namberTre}");
}

else
{
    Console.WriteLine($"max = {namberFir}");
}