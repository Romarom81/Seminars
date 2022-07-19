// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha41()
{
    Console.Write("Укажите количество чисел, которое вы хотите ввести :");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    Console.WriteLine("Необходимо вводить Целые числа. Введите первое целое число:");
    Console.WriteLine("Введите первое целое число:");
    FillArray(array);
    Console.Clear();
    Console.Write("Вы ввели числа:");
    PrintArray(array);
    Console.Write($"В данном списке  {MoreZero(array)}  чисел больше нуля");
    Console.WriteLine(" ");
}
Console.WriteLine(" ");
Zadacha41();


void FillArray(int[] array) // заполение массива в заданном дипазоне числ
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите следующее число:");
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

int MoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;

}