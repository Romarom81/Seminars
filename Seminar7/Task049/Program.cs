// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
void Zadacha049()
{
    Console.WriteLine(" Введите количество строк двумерного массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" Введите количество рядов  двумерного массива:");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array, 2, 11);
    Console.WriteLine(" Задан случайный массив:");
    PrintArray(array);
    Console.WriteLine();
    ChangeElements(array);
    Console.WriteLine(" Массив с заменой значений четных позиций на их квадрат :");
    PrintArray(array);
    Console.WriteLine();
}
Zadacha049();
void FillArray(int[,] array, int minValue, int maxValue)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(minValue, maxValue);
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
void ChangeElements(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
}