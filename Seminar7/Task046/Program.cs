// Задайте двумерный массив размером m×n,заполненный случайными целыми числами.

void Zadacha046()
{
    int rows = 4;
    int columns = 5;
    int[,] array = new int[rows, columns];
    Console.WriteLine();
    FillArray(array,1,11);
    PrintArray(array);
    Console.WriteLine();
}
Zadacha046();
void FillArray(int[,] array, int minValue,int maxValue)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(minValue,maxValue);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);          //легче для программы задать переменные rows, columns ,
    int columns = array.GetLength(1);       // один раз посчитать количество методом array.GetLength
    for (int i = 0; i < rows; i++)          // b передать количество в переменную. Тогда в самом цикле 
    {                                          // не прийдется каждый раз запускать метод для пересчета строк и столбцов. 
        for (int j = 0; j < columns; j++)      // Это облегчает и ускоряет работу программы
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
