// Задайте значения N и M . Напишите прогу, которая выдает все значения в промежутке от N до M
// кратные 3м.

void Zadacha064()
{
    int numberN = 15;
    int numberM = 25;
    Console.Write("Числа: ");
    Recursion(numberN,numberM);
    Console.WriteLine ($"в промежутке от {numberN} до {numberM} кратны трём");
}
Zadacha064();
void Recursion(int numberN, int numberM)
{

    if (numberN > numberM) return;
    if (numberN % 3 == 0) Console.Write($"{numberN},");
    numberN++;
    Recursion(numberN, numberM);
}

