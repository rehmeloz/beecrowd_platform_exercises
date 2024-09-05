// 1006
var culture = new System.Globalization.CultureInfo("en-US");
double A = double.Parse(Console.ReadLine().Trim(), culture);
double B = double.Parse(Console.ReadLine().Trim(), culture);

double pesoA = 3.5;
double pesoB = 7.5;

double media = ((A * pesoA) + (B * pesoB)) / (pesoA + pesoB);

Console.WriteLine("MEDIA = {0:F5}", media);