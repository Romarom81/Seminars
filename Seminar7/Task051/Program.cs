// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
void Zadacha051()
{
    int rows = 5;
    int columns = 5;
    int[,] array = new int[rows, columns];
    Console.WriteLine();
    FillArray(array, 1, 11);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($" Сумма элементов главной диагонали массива равна {Summary(array)} ");
    Console.WriteLine();

}
Zadacha051();
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
int Summary(int[,] array)
{
    int sum = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
           if (i==j) sum += array[i, j];
        }
    }
    return sum;
}


