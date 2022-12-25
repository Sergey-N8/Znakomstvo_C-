/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double getNumber(string message)
{
    double result = 0;
    while (true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return result;
}

(double, double)  GetIntersection(double k1, double b1, double k2, double b2)
{
    double xСoordi = (b2 - b1)/(k1 - k2);

    double yСoordi = k1 * xСoordi + b1;

    return (xСoordi, yСoordi);
}


Console.WriteLine("Для прямой y = k1 * x + b1");
double k1 = getNumber("Задайте k1: ");
double b1 = getNumber("Задайте b1: ");
Console.WriteLine("Для прямой y = k2 * x + b2");
double k2 = getNumber("Задайте k2: ");
double b2 = getNumber("Задайте b2: ");
Console.WriteLine(GetIntersection(k1, b1, k2, b2));