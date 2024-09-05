// 1117
List<double> notasSeparadas = new List<double>();

while(true)
{
    double nota = double.Parse(Console.ReadLine());

    if(nota < 0 || nota > 10)
    {
        Console.WriteLine("nota invalida");
    }
    else
    {
        notasSeparadas.Add(nota);

        if(notasSeparadas.Count == 2)
        {
            double media = notasSeparadas.Average();
            Console.WriteLine("media = {0:F2}", media);
            break;
        }
    }
}