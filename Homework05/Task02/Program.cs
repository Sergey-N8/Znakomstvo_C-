/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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
        array[i] = rnd.Next(-99,100);
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

int GetOddNumbersSumm(int[] array)
{
	int summ = 0;
	for(int i = 1; i < array.Length; i = i + 2)
	{
		summ = summ + array[i];
	}
	return summ;
}

int dimenson = GetNumber("Введите размерность массива");
int[] array = InitArray(dimenson);
PrintArray(array);
int OddNumbersSumm = GetOddNumbersSumm(array);

Console.WriteLine($"Сумма элементов на нечётных позициях: {OddNumbersSumm}");
