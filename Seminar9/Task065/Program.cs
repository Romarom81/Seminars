// // Задайте значения N и M. Напишите прогрумму, которая выдает все натуранльные числа 
// в промежутке от N до M.
void Zadacha065()
{
  int numberN = 15;
  int numberM = 25;
  Recursion( numberN, numberM);
  Console.WriteLine();
}
Zadacha065();
void Recursion(int numberN, int numberM)
{
  
  if (numberN>numberM) return;
  Console.Write(numberN + "\t");
  numberN++;
  Recursion(numberN, numberM);
}
