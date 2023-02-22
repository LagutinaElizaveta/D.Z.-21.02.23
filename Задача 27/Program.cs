// Программа, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int sum(int a)
{
    int result = 0;
    while (a > 0)
    {
        result = result + a % 10;
        a = a / 10;
    }
    return result;
}

Console.WriteLine($"Сумма цифр числа {a} равна {sum(a)}");
