// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования. 
void  Zadacha45 ()
{
int size=10;
int[]array = new int[size];
int[]arraySecond = new int[size];
FillArray(array,1, 10);
PrintArray(array);
for (int i = 0; i < array.Length; i++)
{
    arraySecond[i]=array[i];
}
PrintArray(arraySecond);

}
Zadacha45 ();
void FillArray(int[] array,int startNumber=0, int finishNumber = 0) // заполение массива случайными числами

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