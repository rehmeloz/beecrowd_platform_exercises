// 1051
double renda = double.Parse(Console.ReadLine());
double imposto = 0.0;

if(renda <= 2000.00)
{
    Console.WriteLine("Isento");
}
else if(renda <= 3000.00)
{
    imposto = (renda - 2000.00) * 0.08;
    Console.WriteLine("R$ {0:F2}", imposto);
}
else if(renda <= 4500.00)
{
    imposto = (1000.00 * 0.08) + ((renda - 3000.00) * 0.18);
    Console.WriteLine("R$ {0:F2}", imposto);
}
else
{
    imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((renda - 4500.00) * 0.28);
    Console.WriteLine("R$ {0:F2}", imposto);
}