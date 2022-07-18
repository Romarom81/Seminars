// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
Console.WriteLine ("Введите длину стороны A :");
int SideA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите длину стороны B :");
int SideB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите длину стороны C :");
int SideС = Convert.ToInt32 (Console.ReadLine());

void IsTteangle (int A, int B, int C)
{
if ( SideA+SideB>SideС && SideA+SideС>SideB && SideB+SideС>SideA) Console.WriteLine ($"Треугольник со сторонами {SideA},{SideB},{SideС} существует");
else Console.WriteLine ($"Треугольник со сторонами {SideA},{SideB},{SideС} не может существовать ");
}
IsTteangle (SideA, SideB, SideС);