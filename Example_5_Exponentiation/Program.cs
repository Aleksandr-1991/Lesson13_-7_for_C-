// Возведение в степень  с т.з. рекурсивной функции.
int PowerFor (int a, int n)  // - Итерационный метод.
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}  // - Репитативный метод:
int PowerRec (int a, int n) => n == 0 ? 1 : a * PowerRec(a, n - 1); 
// Стрелочную F-цию лучше не исп т.к. на ней  IDE не покажет, что F-ция рекурсивная.

// - Репитативный метод в улучшенном формате для ускоренного вычисления большого кол-ва итераций:
int PowerRecMath (int a, int n)
{
    if (n==0) return 1;
    else if (n %2 == 0) return PowerRecMath(a * a, n / 2);
    else return a * PowerRecMath (a, n-1);
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024