// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами,
// округлёнными до одного знака.

void Zadacha47()
{
  int rows = 4;
  int columns = 5;
  double[,] array = new double[rows, columns];
  FillArray(array);
  PrintArray(array);
}
Zadacha47();
void FillArray(double[,] array)
{
  Random rand = new Random();
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = Math.Sqrt(rand.Next(1, 10)) + rand.Next(1, 10);
    }
  }
}
void PrintArray(double[,] array)
{
  int rows = array.GetLength(0);          
  int columns = array.GetLength(1);       
  for (int i = 0; i < rows; i++)           
  {                                          
    for (int j = 0; j < columns; j++)      
    {
      Console.Write(Math.Round(array[i, j],1) + "\t");
    }
    Console.WriteLine();
  }
}