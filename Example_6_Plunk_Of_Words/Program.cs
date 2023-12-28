// Перебор слов.
// Блок всех итерационных методов: 
/*

char[] s = { 'a', 'и', 'с', 'в' };
int n = 1;
// Итерационный метод. Для 1-буквенных слов:
for (int i = 0; i < s.Length; i++)
{
    Console.WriteLine($"{n++, -5} {s[i]}");  // "-5" это кол-во пробелов после (ес поставить "+" то до) переменной.
}
// Итерационный метод. Для 2-буквенных слов:
for (int i = 0; i < s.Length; i++)
{
    for (int j = 0; j < s.Length; j++)
    {
        Console.WriteLine($"{n++, -5} {s[i]} {s[j]}");
    }
}
// Итерационный метод. Для 3-буквенных слов:
for (int i = 0; i < s.Length; i++)
{
    for (int j = 0; j < s.Length; j++)
    {
        for (int k = 0; k < s.Length; k++)
        {
            Console.WriteLine($"{n++, -5} {s[i]} {s[j]} {s[k]}");
        }
    }
}   //*/

// - Репитативный метод:
int n = 1;
void FindWords (string alphabet, char[] word, int length = 0)
{
    if(length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i< alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[4]);