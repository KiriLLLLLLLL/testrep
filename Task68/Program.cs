// Показать натуральные числа от N до 1, N задано

//int num = 1;
//int num1 = 10;

//static void NaturalNumbers(int num, int num1)
//{
    //Console.Write(" " + num1);
    //if (num < num1) NaturalNumbers(num, num1 - 1);
//}

//NaturalNumbers(num, num1);


// почему при перестановке аргументов в 9й строке меняется результат????

int num = 1;
int num1 = 10;

static void NaturalNumbers(int num, int num1)
{

    if (num < num1) NaturalNumbers(num + 1, num1);
    Console.Write(" " + num);

}

NaturalNumbers(num, num1);