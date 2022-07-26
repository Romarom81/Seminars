// Заполните спирально массив 4 на 4 числами от 1 до 16.
//  1  2  3  4
// 12  13 14 5
// 11  16 15 6
// 10  9  8  7

void Zadacha58()
{
  int rows = 6;
  int columns = 9;
  int[,] array = new int[rows, columns];
  int index_i = 0;
  int index_j = 0;
  int change_i = 0;
  int change_j = 1;
  int steps = columns;
  int turnCount = 0;

  for (int i = 1; i <= array.Length; i++)
  {
    array[index_i, index_j] = i;
    steps--;
    if (steps == 0)
    {
      steps = columns * (turnCount%2) + rows * ((turnCount+1)%2) -1- turnCount/2;
      int temp = change_i;
      change_i = change_j;
      change_j = -temp;
      turnCount++;
    }
    index_i += change_i;
    index_j += change_j;
  }
PrintArray(array);


}
Zadacha58();

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
