/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

string[] arrey = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

Console.WriteLine($"Введите число от 1 до 7: ");
int namber = int.Parse(Console.ReadLine() ??"");

if(namber > 0 && namber < 6)
{
    Console.WriteLine($"Нет, {arrey[namber - 1]} не является выходным днём");
}
else if(namber > 5 && namber < 8)
{
    Console.WriteLine($"Да, {arrey[namber - 1]} является выходным днём");
}
else
{
    Console.WriteLine($"Введены неверные данные");
}