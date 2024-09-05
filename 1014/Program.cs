// 1014
var culture = new System.Globalization.CultureInfo("en-US");
int x = int.Parse(Console.ReadLine(), culture);
double y = double.Parse(Console.ReadLine(), culture);

double resultado = x / y;

Console.WriteLine("{0:F3} km/l", resultado);