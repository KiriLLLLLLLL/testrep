// Написать программу вычисления функции Аккермана

int AkkermanRecurtion(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((n == 0) && (m > 0))
    {
        return AkkermanRecurtion(m - 1, 1);
    }
    else return AkkermanRecurtion(m - 1, AkkermanRecurtion(m, n - 1));
}

Console.WriteLine(AkkermanRecurtion(3, 10));