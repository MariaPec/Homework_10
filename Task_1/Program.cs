// Есть монотонная последовательность, каждое число встречается ровно то количество раз, 
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Number = Prompt ("Введите N: ");

void PrintSequenceN (int N, int current = 1)
{
    if (current > N)
    {
        return;
    }
    for (int i = 0; i < current; i++)
    {
        Console.Write($"{current}, ");
    }
    PrintSequenceN (N, current + 1);
} 
PrintSequenceN(Number);