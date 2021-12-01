bool TrueFalse(bool x, bool y)
{
    bool res = true;
    bool a = !(x | y);
    bool b = !x & !y;
    Console.WriteLine(a);
    Console.WriteLine(b);
    if (a == b) res = true;
    else res = false;
    return res;
}

bool x = true;

bool y = true;
bool result = TrueFalse(x, y);
Console.WriteLine("Вариант 1 = " + result);

bool x1 = true;
bool y1 = false;
bool result1 = TrueFalse(x1, y1);
Console.WriteLine("Вариант 2 = " + result1);

bool x2 = false;
bool y2 = true;
bool result2 = TrueFalse(x2, y2);
Console.WriteLine("Вариант 3 = " + result2);

bool x3 = false;
bool y3 = false;
bool result3 = TrueFalse(x3, y3);
Console.WriteLine("Вариант 4 = " + result3);