/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

//метод, который получает число с консоли
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

// инициализация двухмерной матрицы
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
    return matrix;
}

int [,] GetMatrixSort(int [,] matrix)
{
    int[,] matrixSort = new int[matrix.GetLength(0),matrix.GetLength(1)];
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixSort[i,j] = matrix[i,j];
        }

        for (int r = 0; r < matrix.GetLength(1); r++)
        {
            if(r > 0 && matrixSort[i,r - 1] < matrixSort[i,r])
            {
                min = matrixSort[i,r - 1];
                matrixSort[i,r - 1] = matrixSort[i,r];
                matrixSort[i,r] = min;
                r = 0;
            }
        }
    }
    return matrixSort;
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
int [,] matrixSort = GetMatrixSort(matrix);

PrintArray(matrix);
Console.WriteLine();
PrintArray(matrixSort);