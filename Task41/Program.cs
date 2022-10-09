Console.Write("Введите колличество чисел:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers =  new int[size];

void SetNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}е значение: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
}

int CountPositiveNumbers(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            amount++;
        }
    }
    return amount;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}

SetNumbers(numbers);
int count = CountPositiveNumbers(numbers);
PrintArray(numbers);
Console.Write($" -> {count}");
Console.WriteLine();
