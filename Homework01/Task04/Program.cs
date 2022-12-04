/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Напишите число: ");
string namberStr = Console.ReadLine();
int namber = Convert.ToInt32(namberStr);
int namber_count = 0;

for(; namber - 1 > namber_count & namber > 1;)
{
    namber_count = namber_count + 2;
    Console.Write($"{namber_count}, ");
}

for(; namber + 1 < namber_count & namber < -1;)
{
    namber_count = namber_count - 2; //перенос
    Console.Write($"{namber_count}, ");
}

