//  Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
void Zadacha039()
{
    int size = 8;
    int[] array = new int[size];
    int[] secondArray = new int[size];
    FillArray(array, 1, 10);
    PrintArray(array);
    Console.WriteLine();
    int maxIndex = array.Length -1;
    int temp;
    /*for (int i = 0; i < array.Length; i++) // разворот массива при помощи второго массива (пустого)
    {
        secondArray [maxIndex-i] = array[i];
    }
    PrintArray(secondArray);
    Console.WriteLine();*/

    for (int i = 0; i < array.Length/2; i++) // поворот одного массива относительно середины (быстрее)
    {
        temp = array[i];
        array[i]=array [maxIndex-i];
        array [maxIndex-i] = temp;
    }
    PrintArray(array);
    Console.WriteLine();
}

// третий метод разворота "метод кортежа" в цикле выполняем (array[i],array [maxIndex-i]) = (array [maxIndex-i],array[i]);
Zadacha039();

// Метод заполение массива случайными числами в заданном диапазоне
void FillArray(int[] array, int startNumber = 0, int finishNumber = 0)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}
void PrintArray(int[] array) // метод печати массива
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(" ");
}