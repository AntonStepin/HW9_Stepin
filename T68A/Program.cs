
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        n++;
        return n;
    }
    else if (m > 0 && n == 0)
    {
       return Akkerman(m - 1, 1);
    }
    else
    {
       
         return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

int result = Akkerman(3, 4);
Console.WriteLine(result);
