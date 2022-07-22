// Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

void Zadacha59()
{
  Random rand = new Random();
  int rows = rand.Next(5, 8);
  int columns = rand.Next(5, 8);
  int[,] array = new int[rows, columns];

  FillArray(array);
  Console.WriteLine();
  PrintArray(array);
  Console.WriteLine();
  int min = array[0, 0];
  int i_min = 0;
  int j_min = 0;
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      if (array[i, j] < min)
      {
        min = array[i, j];
        i_min = i;
        j_min = j;
      }
    }
  }
  Console.WriteLine($" минимальный элемент находится на позиции ({i_min}, {j_min}) и равен {min}");
  int[,] newArray = new int[rows - 1, columns - 1];
  int bias_i = 0;
  for (int i = 0; i < rows - 1; i++)
  {
    if (i == i_min) bias_i++;
    int bias_j = 0;
    for (int j = 0; j < columns - 1; j++)
    {
      if (j == j_min) bias_j++;
      newArray[i, j] = array[i + bias_i, j + bias_j];
    }
  }
  Console.WriteLine ("Вывод итогового массива:");
   PrintArray(newArray);
}

Zadacha59();

void FillArray(int[,] array)
{
  Random rand = new Random();
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = rand.Next(-10, 10);
    }
  }
}
void PrintArray(int[,] array)

{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
}
Console.WriteLine();






