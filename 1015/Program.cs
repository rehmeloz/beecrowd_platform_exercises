// 1015
var culture = new System.Globalization.CultureInfo("en-US");
string[] linha1 = Console.ReadLine().Split(' ');
double x1 = double.Parse(linha1[0], culture);
double y1 = double.Parse(linha1[1], culture);

string[] linha2 = Console.ReadLine().Split(' ');
double x2 = double.Parse(linha2[0], culture);
double y2 = double.Parse(linha2[1], culture);

double resultado = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine("{0:F4}", resultado);
