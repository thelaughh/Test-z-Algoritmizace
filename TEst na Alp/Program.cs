// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<double> seznam = new List<double>();
seznam.Add(0.77);
seznam.Add(150.24);
seznam.Add(125.98);
seznam.Add(50.65);
seznam.Add(53.68);
foreach (double hodnota in seznam)
{
    if (hodnota > 100)
    {
        Console.WriteLine(Math.Ceiling(hodnota));
    }
}

