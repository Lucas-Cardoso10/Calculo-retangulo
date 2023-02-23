using System.Globalization;
using Teste;

Retangulo ret = new Retangulo();

Console.WriteLine("Entre a largura e altura do retângulo: ");
Console.Write("Altura: ");
ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Largura: ");
ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Area " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Perimetro " + ret.perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Diagonal " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

Console.ReadLine();

