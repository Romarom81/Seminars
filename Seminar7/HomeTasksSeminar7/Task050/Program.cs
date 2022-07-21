// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void Zadacha51()
{
  int rows = 8;
  int columns = 5;
  double[,] array = new double[rows, columns];
  FillArray(array);
  Console.WriteLine( $" Задан случайный массив вещественных чисел, состоящий из {rows-1} строк и {columns-1 } столбцов :");
  PrintArray(array);
  ReturnValue(array);
  Console.WriteLine();
}
Zadacha51();
void FillArray(double[,] array)
{
  Random rand = new Random();
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 1; i < rows; i++)
  {
    for (int j = 1; j < columns; j++)
    {
      array[i, j] = Math.Sqrt(rand.Next(1, 10)) + rand.Next(1, 10);
    }
  }
}
void PrintArray(double[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 1; i < rows; i++)
  {
    for (int j = 1; j < columns; j++)
    {
      Console.Write(Math.Round(array[i, j], 1) + "\t");
    }
    Console.WriteLine();
  }
}
void ReturnValue(double[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  double value = 0;
  Console.WriteLine("Введите строку элемента:");
  int indexRow = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите столбец элемента:");
  int IndexColum = Convert.ToInt32(Console.ReadLine());
  if (indexRow < rows && IndexColum < columns)
  {
    value = array[indexRow, IndexColum]; 
    Console.WriteLine("Значение элемента = " + Math.Round (array[indexRow, IndexColum],1));
  }
  else
  {
    Console.WriteLine("Данного элеманта нет в заданном массиве");
  }
}
