// Время на рекурсивные функции уходит часто больше. Из-за большего числа подсчётов. Ниже мы это проверим.

decimal fRec = 0;
decimal fIte = 0;
decimal FibonacciRecursion (int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion (n - 1) + FibonacciRecursion (n - 2);
}
decimal FibonacciIteration (int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte ++;
    }
    return result;
}
// # 1 2 3 4 5 6
// V 1 1 2 3 5 8
DateTime dt =  DateTime.Now;
for (int n = 3; n <= 38; n++)
{
    Console.WriteLine($"FibonacciIteration ({n}) = {FibonacciIteration (n)}.  fIte = {fIte.ToString("### ### ###"), -20}");
    fIte = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
dt =  DateTime.Now;
for (int n = 3; n <= 38; n++)
{
    Console.WriteLine($"FibonacciRecursion ({n}) = {FibonacciRecursion (n)}.  fRec = {fRec.ToString("### ### ###"), -20}");
    fRec = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);