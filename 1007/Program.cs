// 1007
var culture = new System.Globalization.CultureInfo("en-US");
double A = double.Parse(Console.ReadLine().Trim(), culture);
double B = double.Parse(Console.ReadLine().Trim(), culture);
double C = double.Parse(Console.ReadLine().Trim(), culture);

double pesoA = 2;
double pesoB = 3;
double pesoC = 5;

double media = ((A * pesoA) + (B * pesoB) + (C * pesoC)) / (pesoA + pesoB + pesoC);

Console.WriteLine("MEDIA = {0:F1}", media);
