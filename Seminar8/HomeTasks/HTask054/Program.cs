// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
    Random rand = new Random();
    int rows = rand.Next(5, 10);
    int columns = rand.Next(5, 11);
    int[,] array = new int[rows, columns];

    FillArray(array);
    PrintArray(array);
    SortRows(array);
    Console.WriteLine();
    Console.WriteLine(" Массив , в котором строки отсортированы по убыванию:");
    PrintArray(array);

}
Zadacha54();
void FillArray(int[,] array)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(1, 20);
        }
    }
}
void PrintArray(int[,] array)

{
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
}
Console.WriteLine();
void SortRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int temp;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if ( array [i,k] < array [i, k+1])
                {
                    temp = array [i,k];
                    array [i,k] = array [i, k+1];
                    array [i, k+1] = temp;
                }
            }
          
        }

    }

}
