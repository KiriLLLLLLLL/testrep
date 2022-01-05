// Показать натуральные числа от M до N, N и M заданы

string NaturalNumbers(int m, int n)
{

    if (m > n)
    {
        return m + " " + NaturalNumbers(m - 1, n);
    }
    else
    {
        if (m == n)
            {
                return Convert.ToString(m);
            }
        return m + " " + NaturalNumbers(m + 1, n);
    }
}
Console.Write(NaturalNumbers(32, 12));