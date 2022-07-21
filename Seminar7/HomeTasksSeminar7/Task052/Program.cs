// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
  int rows = 6;
  int columns = 8;
  int[,] array = new int[rows, columns];
  FillArray(array);
  PrintArray(array);
  Console.WriteLine();
  AvarageColumn(array);
}
Zadacha52();

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
      Console.Write((array[i, j]) + "\t");
    }
    Console.WriteLine();
  }
}
void AvarageColumn(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  
  double avarage =0;
  for (int j = 0; j < columns; j++)
  { 
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
      sum += array [i,j];
    }
    avarage = sum/rows;
    Console.WriteLine($"Среднее арифметическое столбца {j + 1} = {Math.Round (avarage,2)}");
  }
}
