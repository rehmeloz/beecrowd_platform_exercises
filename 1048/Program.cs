// 1048
double salarioAtual = double.Parse(Console.ReadLine());
double novoSalario;
double aumento;

if(salarioAtual >= 0 && salarioAtual <= 400.00)
{
    novoSalario = salarioAtual * (15.00 / 100);
    aumento = novoSalario + salarioAtual;
    Console.WriteLine("Novo salario: {0:F2}", aumento);
    Console.WriteLine("Reajuste ganho: {0:F2}", novoSalario);
    Console.WriteLine("Em percentual: 15 %");
} 
else if (salarioAtual >= 400.01 && salarioAtual <= 800.00) 
{
    novoSalario = salarioAtual * (12.00 / 100);
    aumento = novoSalario + salarioAtual;
    Console.WriteLine("Novo salario: {0:F2}", aumento);
    Console.WriteLine("Reajuste ganho: {0:F2}", novoSalario);
    Console.WriteLine("Em percentual: 12 %");
} 
else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00)
{
    novoSalario = salarioAtual * (10.00 / 100);
    aumento = novoSalario + salarioAtual;
    Console.WriteLine("Novo salario: {0:F2}", aumento);
    Console.WriteLine("Reajuste ganho: {0:F2}", novoSalario);
    Console.WriteLine("Em percentual: 10 %");
} 
else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
{
    novoSalario = salarioAtual * (7.00 / 100);
    aumento = novoSalario + salarioAtual;
    Console.WriteLine("Novo salario: {0:F2}", aumento);
    Console.WriteLine("Reajuste ganho: {0:F2}", novoSalario);
    Console.WriteLine("Em percentual: 7 %");
}
else if (salarioAtual > 2000.00)
{
    novoSalario = salarioAtual * (4.00 / 100);
    aumento = novoSalario + salarioAtual;
    Console.WriteLine("Novo salario: {0:F2}", aumento);
    Console.WriteLine("Reajuste ganho: {0:F2}", novoSalario);
    Console.WriteLine("Em percentual: 4 %");
}