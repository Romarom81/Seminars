// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии . М=3 N =2, A(M,N)->29
void Zadacha068();
{
int numberM = 2;
int numberN = 3;
Recursion(numberN, numberM);
Console.WriteLine();

}
Zadacha068();
void Recursion(int numberN, int numberM, int sum = 0)
{
    if (numberM==0)
    { 
       Console.WriteLine (numberN+1);
         return;
    }
    if (numberN==0)
    {
        numberM = numberM-1.1;
        return;
    }
    if (numberM>0 || numberN >0)
    {
        Console.Write(numberN + "\t");
    }
        
    numberN++;
    Recursion(numberN, numberM);
}