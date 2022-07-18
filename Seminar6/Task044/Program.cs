// Не используя рекурсию, выведите первые N чисел
 // Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
void Zadacha44()
{
int numberFirst =0;
int numberSecond =1;
int count = 20;
for (int i = 0; i < count; i++)
{
    Console.WriteLine (numberFirst + "\t");
    int temp = numberSecond;
    numberSecond = numberFirst+numberSecond;
    numberFirst= temp;
}
}
Zadacha44();
