/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
*/

int[] InitArray(int size)
{
  int[] array = new int [size];
  Random rnd = new Random();

  for (int i = 0; i < size; i++)
  {
    array[i] = rnd.Next(0,100);
  }
  return array;
}

void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.Write($"{array[array.Length - 1]}]");
}

int size = 8;
int[] array = InitArray(size);
PrintArray(array);