// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае,  если это невозможно, программа должна вывести сообщение для пользователя.

void Zadacha55()
{
  Random rand = new Random();
  int rows = rand.Next(5, 11);
  int columns = rand.Next(5, 11);
  int[,] array = new int[rows, columns];

  FillArray(array);
  Console.WriteLine();
  PrintArray(array);
  Console.WriteLine();
  RowsToColumns (array);
  Console.WriteLine();
   


}
Zadacha55();

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

void RowsToColumns(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  if (rows == columns)
  {
    for (int i = 0; i < columns; i++)
    {
      for (int j = i; j < rows; j++) // при проходе необходимо начинать со следующего j а не с 0, поэтому тоже увеличиваем j на 1. 
      {
        (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
      }
    }
    PrintArray(array);
     Console.WriteLine();
  }
  else 
  {
    Console.WriteLine (" Поменять местами строки и столбцы невозможно т.к не равна длина ");
     Console.WriteLine();
  }

}

