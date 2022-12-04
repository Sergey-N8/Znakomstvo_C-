/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Напишите число: ");
string namberStr = Console.ReadLine();

int namber = Convert.ToInt32(namberStr);

if (namber % 2 == 0)
{
    Console.WriteLine($"Число чётное");
}

else if (namber % 2 != 0)
{
    Console.WriteLine($"Число нечётное");
}

else
{
    Console.WriteLine($"Неправильно введённые данные");
}