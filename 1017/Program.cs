// 1017
var culture = new System.Globalization.CultureInfo("en-US");
int horas = int.Parse(Console.ReadLine(), culture);
int velocidade = int.Parse(Console.ReadLine(), culture);

double divisao = velocidade / 12.0;
double resultado = divisao * horas;

Console.WriteLine("{0:F3}", resultado);