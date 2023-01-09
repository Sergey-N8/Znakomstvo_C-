/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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



int[,] GetMultiplicationMatrix(int[,] matrix, int[,] matrixTwo)
{
    int[,] matrixResult = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixResult[i,j] = matrix[i,j] * matrixTwo[i,j];
        }
    }
    return (matrixResult);
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
int[,] matrixTwo = InitMatrix(m,n);
int[,] matrixResult = GetMultiplicationMatrix(matrix, matrixTwo);

PrintArray(matrix);
Console.WriteLine();
PrintArray(matrixTwo);
Console.WriteLine();
PrintArray(matrixResult );