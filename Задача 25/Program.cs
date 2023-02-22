// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
if (B <= 0)
{
    Console.WriteLine($"Число {B} ввдено некорректно: оно не является натуральным.");
    return;
}

int Exp(int A, int B)
{
    int result = A;
    for (int i = 2; i <= B; i++)
    {
        result *= A;
    }
    return result;
}

Console.WriteLine($"{A} в степени {B} равно {Exp(A, B)}");