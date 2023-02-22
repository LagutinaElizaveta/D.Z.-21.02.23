// Программа, которая задаёт массив из 8 элементов и выводит их на экран
Console.Write("Введите количество элементов в массиве: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите начальное значение диапазона случайных чисел: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите конечное значение диапазона случайных чисел: ");
int b = int.Parse(Console.ReadLine());

int[] GenerateArray(int length, int a, int b)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(a, b + 1);
    }
    return result;
}
int[] array = GenerateArray(length, a, b);
Console.WriteLine($"[ {String.Join(", ", array)} ]");