// Программа, которая принимает на вход число и возвращает сумму его цифр. 

void Zadacha067()
{
  Random rand = new Random();
  int num = rand.Next(500, 10000);
  Console.WriteLine ($"Рандомное число {num}");
  Console.WriteLine();
  Recursion(num);
  Console.WriteLine();
}
Zadacha067();
void Recursion(int num, int sum = 0)
{

  if (num == 0)
  {
    Console.WriteLine($"Сумма цифр заданного числа равна = {sum}");
    return;
  }
  sum += num%10;
  num = num / 10;
  Recursion(num, sum);
}
