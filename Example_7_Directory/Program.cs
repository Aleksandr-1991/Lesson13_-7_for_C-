using System.IO;
// string path = "C:/Обуч!";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();
// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

void CatalogInfo(string path, string indent = "") // 1 арг: путь. 2 арг: искуст приём, позв делать отступы для удобства просмотра.
{
    DirectoryInfo catalog = new DirectoryInfo(path); // Получаем инфу о дир., в к-ую зашли.
    DirectoryInfo[] catalogs = catalog.GetDirectories(); // Получаем массив всех файлов в этой папке.
    for (int i = 0; i < catalogs.Length; i++) // Пробегаем по ним.
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}"); // Выводя инфу о текущ каталоге,
        CatalogInfo(catalogs[i].FullName, indent + "  "); // мы б-рекурсивно заныривать и смотреть все папки, к-ые были получены.
    }
    FileInfo[] files = catalog.GetFiles(); // после окончания вывода папок, мы получаем весь списoк файлов текущей дир.
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}"); // и показываем их.
    }
}
string path = "C:/Обуч!";
CatalogInfo(path);