// 1060
List<double> valores = new List<double>();
double valor;

for(double i = 0; i < 6; i++)
{
    valor = double.Parse(Console.ReadLine());
    valores.Add(valor);
}

int positivos = 0;

foreach(double v in valores)
{
    if(v > 0)
    {
        positivos++;
    }
}

Console.WriteLine("{0} valores positivos", positivos);