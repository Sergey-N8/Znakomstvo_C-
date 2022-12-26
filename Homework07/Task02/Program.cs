/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/


int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)&& result >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return result;
}


int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
            
        }
    }
    return (matrix);
}


string GetStatus(int x, int y, int[,] matrix)
{
    string result = String.Empty;
    if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
    {
        result = $"Значение элемента {x},{y} ровняется {matrix[x,y]}";
    }

    else
    {
        result = $"Такого элемнта нет";
    }
    return result; 
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int n = GetNumber($"Введите колличество столбцов");
int m = GetNumber($"Введите колличество сторк");
int[,] matrix = InitMatrix(m,n);
int x = GetNumber($"Введите строку элемента (подщёт элементов начанается с 0)");
int y = GetNumber($"Введите столбец элемента (подщёт элементов начанается с 0)");

PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(GetStatus(x,y,matrix));