/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
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

double GetGetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

int x1 = GetNamber("Введите x1");
int y1 = GetNamber("Введите y1");
int z1 = GetNamber("Введите z1");
int x2 = GetNamber("Введите x2");
int y2 = GetNamber("Введите y2");
int z2 = GetNamber("Введите z2");

Console.WriteLine(GetGetDistance(x1,y1,z1,x2,y2,z2));