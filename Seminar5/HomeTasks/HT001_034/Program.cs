// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
void Zadacha034()
{
  int size = 20;
  int[] array = new int[size];
  FillArray(array,100,1000);
  Console.WriteLine("Задан массив трехзначных чисел:");
  PrintArray(array);
  Console.WriteLine();
  Console.WriteLine($"В заданном массиве {QuantityNumbers(array)} чётных чисел");
  Console.WriteLine();
}
Zadacha034();
void FillArray(int[] array,int startNumber=0, int finishNumber = 0) // заполение массива случайными числами

{
  Random random = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(startNumber, finishNumber);
  }
}

void PrintArray(int[] array) // метод печати массива
{
  Console.WriteLine();
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.WriteLine(" ");
}

int QuantityNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) count++;
  }
  return count;
}