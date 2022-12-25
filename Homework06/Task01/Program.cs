/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int[] InitArray(string[] massege)
{
  int[] array = new int [massege.Length];

  for (int i = 0; i < massege.Length; i++)
  {
    array[i] = Convert.ToInt32(massege[i]);
  }
  return array;
}

int GetPositive(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0)
      count++;
  }
  return count;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}, ");
  }
}

Console.Write("Введите ряд чисел, разделенных запятой: ");
string[] massege = Console.ReadLine().Split(",");
int[] array = InitArray(massege);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Чисел больше нуля:{GetPositive(array)}");