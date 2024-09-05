// 1010
var culture = new System.Globalization.CultureInfo("en-US");
string nome = Console.ReadLine().Trim();
double salarioFixo = double.Parse(Console.ReadLine().Trim(), culture);
double totalVendasMes = double.Parse(Console.ReadLine().Trim(), culture);
double porcentagem = 15;

double bonus = (totalVendasMes * porcentagem) / 100;
double resultado = bonus + salarioFixo;

Console.WriteLine("TOTAL = R$ {0:F2}", resultado);