/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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


int[,,] InitMatrix(int m, int n, int z)
{
    int[,,] matrix = new int[m,n,z];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int r = 0; r < matrix.GetLength(2); r++)
            {
                matrix[i,j,r] = rnd.Next(10,100);  
            }
        }
    }
    return (matrix);
}

void PrintArray(int[,,] matrix)
{
    for (int r = 0; r < matrix.GetLength(2); r++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i,j,r]}({i},{j},{r}) ");
            } 
        }
        Console.WriteLine();
    }
}

int n = GetNumber($"Введите колличество сторк");
int m = GetNumber($"Введите колличество столбцов");
int z = GetNumber($"Введите объём");

int[,,] matrix = InitMatrix(m,n,z);

PrintArray(matrix);
Console.WriteLine();