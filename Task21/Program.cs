int quarter = new Random().Next(1, 5);
Console.WriteLine("Номер четверти " + quarter);
if (quarter == 1) Console.WriteLine("Диапазон х < 0 и у > 0");
if (quarter == 2) Console.WriteLine("Диапазон х > 0 и у > 0");
if (quarter == 3) Console.WriteLine("Диапазон х < 0 и у < 0");
if (quarter == 4) Console.WriteLine("Диапазон х > 0 и у < 0");