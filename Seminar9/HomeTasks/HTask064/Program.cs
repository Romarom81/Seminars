// Задайте значения N и M . Напишите прогу, которая выдает все значения в промежутке от N до M
// кратные 3м.

void Zadacha064()
{
    int numberN = 10;
    int numberM = 25;
    int size = numberM - numberN+1;
    int[] array = new int[size];
    FillArray(array,numberN,numberM);
    Console.WriteLine ("задан массив:");
    PrintArray(array);
    Console.Write (" Числа : ");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%3==0)
        {
            Console.Write ($"{array[i]},");
        }
    }
    Console.WriteLine (" заданного массива кратны трём. ");
    
}
Zadacha064();
Console.WriteLine();
void FillArray(int [] array,int numberN,int numberM) // заполение массива в заданном дипазоне числ
{
        
     for (int i = 0; i < array.Length; i++)
    {
      array [i] = numberN;
      numberN++;
      
    }
    
}

void PrintArray(int[] array) // метод печати массива
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine(" ");
}


