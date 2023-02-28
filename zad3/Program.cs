// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
int m = InputInt("Введем число m:");
int n = InputInt("Введем число n:");
Console.WriteLine($"A({m}, {n}) = {Akerman(m, n)}");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Akerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akerman(m - 1, 1);
    else
        return Akerman(m - 1, Akerman(m, n - 1));
}

