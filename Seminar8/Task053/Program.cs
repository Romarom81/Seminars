// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void Zadacha53()
{
  int rows = 6;
  int columns = 5;
  int[,] array = new int[rows, columns];
  FillArray(array);
  Console.WriteLine();
  PrintArray(array);
  Console.WriteLine();
  ChangeRows(array);
  Console.WriteLine();
  PrintArray(array);
  Console.WriteLine();
  ChangeRows2(array);
  Console.WriteLine();
  PrintArray(array);
}
Zadacha53();

void FillArray(int[,] array)
{
  Random rand = new Random();
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = rand.Next(1, 100);
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

void ChangeRows(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  int temp;

  for (int j = 0; j < columns; j++)
  {
    temp = array[rows - 1, j];
    array[rows - 1, j] = array[0, j];
    array[0, j] = temp;

  }
}

// второе решение с использованием кортежа чисел, 
// перебираем только столбцы и меняем 1 и последний элеметы. 
void ChangeRows2(int[,] array)
{
   int lastRow = array.GetLength (0)-1;
   int columns = array.GetLength (1);
   for (int j = 0; j < columns; j++)
   {
       (array[0,j],array [lastRow,j]) = (array[lastRow,j],array[0,j] );
   }
}
