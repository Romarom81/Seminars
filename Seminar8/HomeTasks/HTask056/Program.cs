// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha56()
{
  int rows = 6;
  int columns = 6;
  int[,] array = new int[rows, columns];

  FillArray(array);
  PrintArray(array);
  RowMinSum(array);
   Console.WriteLine();

}
Zadacha56();
void FillArray(int[,] array)
{
  Random rand = new Random();
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = rand.Next(1, 10);
    }
  }
}
void PrintArray(int[,] array)
{
  Console.WriteLine(" Задан массив чисел: ");
  Console.WriteLine();
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
  Console.WriteLine();
}

int FirstRowSum(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  int sumFirstRow = 0;
  for (int i = 0; i < columns;)
  {
    for (int j = 0; j < columns; j++)
    {
      sumFirstRow += array[0, j];
    }
    break;
  }
  return sumFirstRow;
}
void RowMinSum(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  int minSummary = FirstRowSum(array);
  int minRow = 0;
  
  for (int i = 1; i < rows; i++)
  {
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
      sum += array[i, j];
    }
       
    if (sum < minSummary)
    {
      minSummary = sum;
      minRow = i;
    } 
  }
  Console.WriteLine();
  Console.WriteLine($" Строка {minRow+1} с наименьшей суммой элементов ");
}






