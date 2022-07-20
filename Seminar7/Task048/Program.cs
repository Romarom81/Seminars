// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n.
// Выведите полученный массив на экран.

internal class Program
{
    private static void Main(string[] args)
    {
        void Zadacha048()
        {
            int rows = 5;
            int columns = 5;
            int[,] array = new int[rows, columns];
            Console.WriteLine();
            FillArray(array, 1, 11);
            PrintArray(array);
            Console.WriteLine();
        }
        Zadacha048();
        void FillArray(int[,] array, int minValue, int maxValue)
        {

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = i + j;
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
    }
}