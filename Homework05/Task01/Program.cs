/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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

int[] InitArray(int dimenson)
{
    int[] array = new int [dimenson];
    Random rnd = new Random();

    for (int i = 0; i < dimenson; i++)
    {
        array[i] = rnd.Next(100,1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int GetEvenSumm(int[] array)
{
	int summ = 0;
	for(int i = 0; i < array.Length; i++)
	{
		if(array[i] % 2 == 0)
			summ++;
	}
	return summ;
}

int dimenson = GetNumber("Введите размерность массива");
int[] array = InitArray(dimenson);
PrintArray(array);
int evenSumm = GetEvenSumm(array);

Console.WriteLine($"Колличество чётных: {evenSumm}");
