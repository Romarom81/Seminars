// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha56()
{
    int rows = 6;
    int columns = 6;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    RowWithMinSummary(array);


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

void RowWithMinSummary(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sum =0;
    int[] ArraySumm = new int [rows];
    int minIndex = ArraySumm.Length-1;
        for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
          
        for (int k = 0; k < ArraySumm.Length; k++)
        {
            ArraySumm [k] = sum;
        }
        
        for (int k = 0; k < ArraySumm.Length; k++)
        {
            if (k < minIndex) minIndex = k;
        }     
        
    }
    Console.WriteLine ( $"Строка {minIndex} содержит мнаименьшую сумму элементов");

    
}