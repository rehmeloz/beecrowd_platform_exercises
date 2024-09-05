// 1011
var culture = new System.Globalization.CultureInfo("en-US");
string[] linha1 = Console.ReadLine().Split(' ');
int codigoPeca1 = int.Parse(linha1[0], culture);
int numPecas1 = int.Parse(linha1[1], culture);
double valorUnitarioPeca1 = double.Parse(linha1[2]);

string[] linha2 = Console.ReadLine().Split(' ');
int codigoPeca2 = int.Parse(linha2[0], culture);
int numPecas2 = int.Parse(linha2[1], culture);
double valorUnitarioPeca2 = double.Parse(linha2[2]);

double valorPecas1 = numPecas1 * valorUnitarioPeca1;
double valorPecas2 = numPecas2 * valorUnitarioPeca2;
double total = valorPecas1 + valorPecas2;

Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);