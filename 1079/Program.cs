// 1079
int quantidadeValores = int.Parse(Console.ReadLine());
string[] valores;
double resultado = 0;
double[] resultados = new double[3];

for(int i = 0; i < quantidadeValores; i++)
{
    valores = Console.ReadLine().Split(" ");
    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);
    double c = double.Parse(valores[2]);

    double pesoA = a * 2;
    double pesoB = b * 3;
    double pesoC = c * 5;

    double soma = pesoA + pesoB + pesoC;
    resultado = soma / 10;
    resultados[i] = resultado;
}

for(int i = 0; i < resultados.Length; i++)
{
    Console.WriteLine("{0:F1}", resultados[i]);
}