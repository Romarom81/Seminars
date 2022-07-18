// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine ("Введите число:");
int NumberDec = Convert.ToInt32 (Console.ReadLine());
Console.Write ($"Число {NumberDec} в двоичной системе имеет вид:");

void ConvertDecNumber (int Number)
{
     int result = 0;
     int bias = 1;

     while (Number >0)
     {
        result +=Number%2 * bias;
        bias *= 10;
        Number /=2;
     }
     
     Console.WriteLine (result);
  
}
ConvertDecNumber (NumberDec);