using System.Text;

while (true)
{
    Console.WriteLine("Введите Строку");
    string h = Console.ReadLine();
    //bool noom = int.TryParse(h, out int n);
    //if (noom = false)
    //{
    //    Console.WriteLine("Впишите корректные данные");
    //    return;
    //}
    Console.WriteLine("Введите число сколько раз должна повторяться строка");
    string j = Console.ReadLine();
    bool moon = int.TryParse(j, out int m);
    if (moon = false)
    {
        Console.WriteLine("Впишите корректные данные");
        return;
    }
    var str = new StringBuilder();
    for (int i = 0; i < m; i++)
    {
        str.Append(h);
    }
    Console.WriteLine(str.ToString());
}