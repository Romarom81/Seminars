// // Задайте значения N и M . Напишите прогу, которая выдает сумму 
// натуральных значений в промежутке от N до M
void Zadacha066()
{
  int numberN = 5;
  int numberM = 10;
  Recursion( numberN, numberM);
  Console.WriteLine();

}
Zadacha066();
void Recursion(int numberN, int numberM, int sum =0 )
{
  if (numberN>numberM) 
  {
    Console.WriteLine($"Сумма цифр данного диапазона равна = {sum}");
    return;
  }
  Console.Write(numberN + "\t");
  sum += numberN;
  numberN++;
  Recursion(numberN, numberM, sum);
 
}