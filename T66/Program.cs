// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNumber(int FromM, int ToN)
{

    if (FromM > ToN)
    {
        int temp = FromM;
        FromM = ToN;
        ToN = temp;
    }
    int result = ToN;
    if (FromM < ToN)
    {
        result += SumOfNumber(FromM, ToN-1);
    }
    return result;
}

int From = 8;
int To = 4;
int SumAllNumbersFromTo = SumOfNumber(From,To);
Console.Write(SumAllNumbersFromTo);
