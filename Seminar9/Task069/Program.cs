// Напишите программу, которая на вход принимает два числа,
// и возводит число А в целую степень В с помощью рекурсии. 

int A = 5;
int B = 5;
Recursion(A, B);

void Recursion(int A, int B, int result = 1)
{
  if (B == 0)
  {
    Console.WriteLine(result);
    return;
  }
  result *= A;
  B--;
  Recursion(A, B, result);
}