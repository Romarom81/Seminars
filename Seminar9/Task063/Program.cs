// Задайте значение N. Напишите прогрумму, которая выдает все натуранльные числа 
// в промежутке от 1 до N.

void Zadacha063()
{
  int number = 15;
  int count = 1;
  Recursion(count, number);
  Console.WriteLine();
}
Zadacha063();
void Recursion(int count, int number)
{
  if (count>number) return;
  Console.Write(count + "\t");
  count++;
  Recursion(count, number);

}
