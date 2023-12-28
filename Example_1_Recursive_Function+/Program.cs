// Cобрать строку с числами от а до b, a =< b.
string NumbersFor (int a, int b)
{
    string result = String.Empty;
    for (; a <= b; a++)
    {
        result += $"{a}";
    }
    return result;
}
string NumbersRec (int a, int b)
{
    if (a < b) return $"{a}" + NumbersRec(a + 1, b);
    else return $"{a}";
}
Console.WriteLine(NumbersFor(1, 10));
Console.Write(NumbersRec(1, 10));