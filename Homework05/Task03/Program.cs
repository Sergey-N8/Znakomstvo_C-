/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
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

double[] InitArray(int dimenson)
{
    double[] array = new double [dimenson];
    Random rnd = new Random();

    for (int i = 0; i < dimenson; i++)
    {
        array[i] = rnd.Next(1,100);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

(double, double) GetDifferenceNumber(double[] array)
{
	int summ = 0;
  double max = array[0];
  double min = array[0];
  for(int i = 0; i < array.Length; i++)
  {
    if (array[i] > max)
        max = array[i];

    else if (array[i] < min)
        min = array[i];
  }
  return (max, min);
}


int dimenson = GetNumber("Введите размерность массива");
double[] array = InitArray(dimenson);
PrintArray(array);
(double max, double min) = GetDifferenceNumber(array);

Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементом массива {max - min}");