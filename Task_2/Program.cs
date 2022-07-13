// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int numberM = Prompt("Введите M: ");
int numberN = Prompt("Введите N: ");

int Akkermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return Akkermann(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akkermann(m - 1, Akkermann(m, n - 1));
    }

    return n + 1;
}

Console.WriteLine(Akkermann(numberM, numberN));