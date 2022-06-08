// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 5; N = 1. -> "5, 4, 3, 2, 1"
// M = 8; N = 4. -> "8, 7,6, 5, 4"

void NumberFromTo(int FromM, int ToN)
{
    if (FromM < ToN)
    {
        int temp = ToN;
        ToN = FromM;
        FromM = temp;
    }
    if (FromM > ToN)
    {
        Console.Write($"{FromM}, ");
        NumberFromTo(FromM - 1, ToN);
    }
    else
    {
        Console.Write($"{ToN}");
    }
}

int From = - 5;
int To = -1;
NumberFromTo(From, To);