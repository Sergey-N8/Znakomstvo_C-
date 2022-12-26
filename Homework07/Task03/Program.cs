/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
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



void GetSumm(int[,] matrix)
{
    double summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i,j];
            
        }
        Console.Write($"{summ/matrix.GetLength(1)}, ");
        summ = 0;
    }
}


void PrintArray(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int n = GetNumber($"ВВведите колличество сторк");
int m = GetNumber($"ведите колличество столбцов");

int[,] matrix = InitMatrix(m,n);

PrintArray(matrix);
Console.WriteLine();
GetSumm(matrix);