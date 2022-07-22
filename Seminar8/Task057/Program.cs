// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
 // информацию о том, сколько раз встречается элемент входных данных.


void Zadacha57()
{
  Random rand = new Random();
  int rows = rand.Next(5, 11);
  int columns = rand.Next(5, 11);
  int[,] array = new int[rows, columns];
  int [] dictionary = new int[10];

  FillArray(array);
  Console.WriteLine();
  PrintArray(array);
  Console.WriteLine();
 ListElemetts (array,dictionary);

}
Zadacha57();

void FillArray(int[,] array)
{
  Random rand = new Random();
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = rand.Next(0, 10);
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
Console.WriteLine ();

void ListElemetts (int[,] array, int [] dictionary)
{
   int rows = array.GetLength(0);
  int columns = array.GetLength(1);

   for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      dictionary [array [i,j]]++;
    }
  }
  for (int i = 0; i < dictionary.Length; i++)
  {
    Console.WriteLine ($" Число{i} встречается в массиве {dictionary[i]} раз");
  }
}



