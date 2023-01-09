/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int [,] InitMatrix(int m)
{
    int[,] matrix = new int[m,m];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          matrix[i,j] = rnd.Next(0,10);
        }
    }
    return (matrix);
}

int[] GetArraySum(int [,] matrix)
{
    int[] matrixResult = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixResult[i] = matrixResult[i] + matrix[i,j];
        }
    }
    return matrixResult;
}

string GetMinStroka(int[] matrixResult)
{
    int min = matrixResult[0];
    int result = 0;
    for (int i = 0; i < matrixResult.Length; i++)
    {
        if(matrixResult[i] < min)
        {
            min = matrixResult[i];
            result = i;
        }
    }
    return $"{result} Наименьшая строка (строки считаются с 0)";
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

void PrintArrayOne(int[] array)
{
    Console.WriteLine($"Сумма элементов по строкам:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int m = GetNumber($"Введите колличество сторк и столбцов");

int[,] matrix = InitMatrix(m);
int[] MinStroka = GetArraySum(matrix);

PrintArray(matrix);
Console.WriteLine();
PrintArrayOne(MinStroka);
Console.WriteLine();
Console.WriteLine(GetMinStroka(MinStroka));
