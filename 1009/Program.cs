// 1009
var culture = new System.Globalization.CultureInfo("en-US");
int numFuncionario = int.Parse(Console.ReadLine().Trim(), culture);
int numHorasTrabalhadas = int.Parse(Console.ReadLine().Trim(), culture);
double valorHora = double.Parse(Console.ReadLine().Trim(), culture);

double salario = numHorasTrabalhadas * valorHora;

Console.WriteLine("NUMBER = {0}", numFuncionario);
Console.WriteLine("SALARY = U$ {0:F2}", salario);
