// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
void Zadacha061 ()
{
Random rand = new Random ();
int rowsFirst = rand.Next (3,7);
int columnsFirst = rand.Next (3,7);
int rowsSec = columnsFirst;
int columnsSec = rand.Next (3,7);

int [,] firstArray = new int [ rowsFirst, columnsFirst];
int [,] SecondArray = new int [rowsSec, columnsSec];
int [,] result = new int [rowsFirst, columnsSec];

FillArray(firstArray);
FillArray(SecondArray);
PrintArray(firstArray);
PrintArray(SecondArray);

for (int i = 0; i < rowsFirst; i++)
{
    for (int j = 0; j < columnsFirst; j++)
    {
        for (int k = 0; k < rowsSec; k++)
        {
            result [i,j] += firstArray[i,k]*SecondArray[k,j];
        }
    }
}
PrintArray(result);
}

Zadacha061 ();


void FillArray(int[,] array)
{
  Random rand = new Random();
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = rand.Next(2, 11);
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