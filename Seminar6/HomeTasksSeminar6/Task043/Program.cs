// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Zadacha43 ()
{

   Console.WriteLine ("Введите значение k1:");
   double k1 = Convert.ToInt32 (Console.ReadLine());
   Console.WriteLine ("Введите значение b1:");
   double b1 = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("Введите значение k2:");
   double k2 = Convert.ToInt32 (Console.ReadLine());
   Console.WriteLine ("Введите значение b2:");
   double b2 = Convert.ToInt32 (Console.ReadLine());
   double x = (b2-b1)/(k2-k1);
   double y = k1 * x +b1;
   Console.Write ($"Точка пересечения заданных прямых имеет координаты x = {x} и y = {y}");
   Console.WriteLine ("");
}
Zadacha43();
