/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
string namberFirStr = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string namberSecStr = Console.ReadLine();


int namberFir = Convert.ToInt32(namberFirStr);
int namberSec = Convert.ToInt32(namberSecStr);

if (namberFir > namberSec)
{
    Console.WriteLine($"max = первое число = {namberFir}, min = второе число = {namberSec}");
}

else if (namberFir < namberSec)
{
    Console.WriteLine($"max = второе число = {namberSec}, min = первое число = {namberFir} ");
}

else
{
    Console.WriteLine($"Неправильно введённые данные");
}