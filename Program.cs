using System.Security.Cryptography;

Console.Clear();
/*
// 1001
int A = int.Parse(System.Console.ReadLine().Trim());
int B = int.Parse(System.Console.ReadLine().Trim());

var X  = A + B;

Console.WriteLine("X = {0}", X);
*/

/* 
// 1002
int nota = 6;
string musica = "Yesterday";
if (nota <= "6")
{
    Console.WriteLine(musica + " -> essa música não é tão boa");
}
else
{
    Console.WriteLine(musica + " -> essa música é ótima");
}
*/

/*
// 1003
double raio = double.Parse(System.Console.ReadLine().Trim());

double area = 3.14159 * Math.Pow(raio, 2);

Console.WriteLine("A={0:F4}", area);
*/

/*
// 1004
int A = int.Parse(Console.ReadLine().Trim());
int B = int.Parse(Console.ReadLine().Trim());

int soma = A + B;

Console.WriteLine("SOMA = {0}", soma);
*/

/*
// 1005
int A = int.Parse(Console.ReadLine().Trim());
int B = int.Parse(Console.ReadLine().Trim());

int PROD = A * B;

Console.WriteLine("PROD = {0}", PROD);
*/

/*
// 1006
var culture = new System.Globalization.CultureInfo("en-US");
double A = double.Parse(Console.ReadLine().Trim(), culture);
double B = double.Parse(Console.ReadLine().Trim(), culture);

double pesoA = 3.5;
double pesoB = 7.5;

double media = ((A * pesoA) + (B * pesoB)) / (pesoA + pesoB);

Console.WriteLine("MEDIA = {0:F5}", media);
*/

/*
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
*/

/*
// 1008
int A = int.Parse(Console.ReadLine().Trim());
int B = int.Parse(Console.ReadLine().Trim());
int C = int.Parse(Console.ReadLine().Trim());
int D = int.Parse(Console.ReadLine().Trim());

int diferenca =  (A * B - C * D);

Console.WriteLine("DIFERENCA = {0}", diferenca);
*/

/*
// 1009
var culture = new System.Globalization.CultureInfo("en-US");
int numFuncionario = int.Parse(Console.ReadLine().Trim(), culture);
int numHorasTrabalhadas = int.Parse(Console.ReadLine().Trim(), culture);
double valorHora = double.Parse(Console.ReadLine().Trim(), culture);

double salario = numHorasTrabalhadas * valorHora;

Console.WriteLine("NUMBER = {0}", numFuncionario);
Console.WriteLine("SALARY = U$ {0:F2}", salario);
*/

/*
// 1010
var culture = new System.Globalization.CultureInfo("en-US");
string nome = Console.ReadLine().Trim();
double salarioFixo = double.Parse(Console.ReadLine().Trim(), culture);
double totalVendasMes = double.Parse(Console.ReadLine().Trim(), culture);
double porcentagem = 15;

double bonus = (totalVendasMes * porcentagem) / 100;
double resultado = bonus + salarioFixo;

Console.WriteLine("TOTAL = R$ {0:F2}", resultado);
*/

/*
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
*/

/*
// 1012
int raio = int.Parse(Console.ReadLine().Trim());

double resultado = (4/3.0) * 3.14159 * Math.Pow(raio, 3);

Console.WriteLine("VOLUME = {0:F3}", resultado);
*/
/*
string[] linha = Console.ReadLine().Split(' ');
double A = double.Parse(linha[0]);
double B = double.Parse(linha[1]);
double C = double.Parse(linha[2]);

double areaTriangulo = (A * C) / 2;
double areaCirculo = 3.14159 * Math.Pow(C, 2);
double areaTrapezio = (A + B) * C / 2;
double areaQuadrado = Math.Pow(B, 2);
double areaRetangulo = A * B;

Console.WriteLine("TRIANGULO: {0:F3}", areaTriangulo);
Console.WriteLine("CIRCULO: {0:F3}", areaCirculo);
Console.WriteLine("TRAPEZIO: {0:F3}", areaTrapezio);
Console.WriteLine("QUADRADO: {0:F3}", areaQuadrado);
Console.WriteLine("RETANGULO: {0:F3}", areaRetangulo);
*/

/*
// 1013
string[] linha = Console.ReadLine().Split(' ');
int A = int.Parse(linha[0]);
int B = int.Parse(linha[1]);
int C = int.Parse(linha[2]);

int maiorAB = (A + B + Math.Abs(A - B)) / 2;
int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;
       
Console.WriteLine("{0} eh o maior", maiorABC);
*/

/*
// 1014
var culture = new System.Globalization.CultureInfo("en-US");
int x = int.Parse(Console.ReadLine(), culture);
double y = double.Parse(Console.ReadLine(), culture);

double resultado = x / y;

Console.WriteLine("{0:F3} km/l", resultado);
*/

/*
// 1015
var culture = new System.Globalization.CultureInfo("en-US");
string[] linha1 = Console.ReadLine().Split(' ');
double x1 = double.Parse(linha1[0], culture);
double y1 = double.Parse(linha1[1], culture);

string[] linha2 = Console.ReadLine().Split(' ');
double x2 = double.Parse(linha2[0], culture);
double y2 = double.Parse(linha2[1], culture);

double resultado = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine("{0:F4}", resultado);
*/

/*
// 1016
int distancia = int.Parse(Console.ReadLine());

int resultado = distancia * 2;

Console.WriteLine("{0} minutos", resultado);
*/

/*
// 1017
var culture = new System.Globalization.CultureInfo("en-US");
int horas = int.Parse(Console.ReadLine(), culture);
int velocidade = int.Parse(Console.ReadLine(), culture);

double divisao = velocidade / 12.0;
double resultado = divisao * horas;

Console.WriteLine("{0:F3}", resultado);
*/

/*
// 1018
int N = int.Parse(Console.ReadLine());
        
Console.WriteLine(N);
        
int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
int[] quantidade = new int[notas.Length];

int valorRestante = N;
        
for (int i = 0; i < notas.Length; i++)
{
    quantidade[i] = valorRestante / notas[i];
    valorRestante %= notas[i];
}

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"{quantidade[i]} nota(s) de R$ {notas[i]},00");
}
*/

/*
// 1019
int N = int.Parse(Console.ReadLine());

TimeSpan duracao = TimeSpan.FromSeconds(N);
string formato = $"{duracao.Hours + (duracao.Days * 24)}:{duracao.Minutes:D1}:{duracao.Seconds:D1}";

Console.WriteLine(formato);
*/

/*
// 1020
int idadeDias = int.Parse(Console.ReadLine());

int idadeAnos = idadeDias / 365;
int diasRestantes = idadeDias % 365;
int idadeMeses = diasRestantes  / 30;
int idadeDiasRestantes =  diasRestantes % 30;

Console.WriteLine("{0} ano(s)", idadeAnos);
Console.WriteLine("{0} mes(es)", idadeMeses);
Console.WriteLine("{0} dia(s)", idadeDiasRestantes);
*/

/*
// 1038
string[] linha = Console.ReadLine().Split(' ');
double codigo = double.Parse(linha[0]);
int quantidade = int.Parse(linha[1]);

double resultado;

if(codigo == 1){
    resultado = 4.00 * quantidade;
    Console.WriteLine("Total: R$ {0:F2}", resultado);
}
if(codigo == 2){
    resultado = 4.50 * quantidade;
    Console.WriteLine("Total: R$ {0:F2}", resultado);
}
if(codigo == 3){
    resultado = 5.00 * quantidade;
    Console.WriteLine("Total: R$ {0:F2}", resultado);
}
if(codigo == 4){
    resultado = 2.00 * quantidade;
    Console.WriteLine("Total: R$ {0:F2}", resultado);
}
if(codigo == 5){
    resultado = 1.50 * quantidade;
    Console.WriteLine("Total: R$ {0:F2}", resultado);
}
*/

/*
// 1035
string[] linha = Console.ReadLine().Split(' ');
int A = int.Parse(linha[0]);
int B = int.Parse(linha[1]);
int C = int.Parse(linha[2]);
int D = int.Parse(linha[3]);

if((B > C) && (D > A) && (C + D) > (A + B) && (C > 0) && (D > 0) && (A % 2 == 0)){
    Console.WriteLine("Valores aceitos");
} else {
    Console.WriteLine("Valores nao aceitos");
}
*/

/*
// 1036
string[] linha = Console.ReadLine().Split(' ');
double A = double.Parse(linha[0]);
double B = double.Parse(linha[1]);
double C = double.Parse(linha[2]);

if(A == 0){
    Console.WriteLine("Impossivel calcular");
} else {
    double delta = B * B - 4 * A * C;
        if(delta < 0){
            Console.WriteLine("Impossivel calcular");
        } else {
            double r1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double r2 = (-B - Math.Sqrt(delta)) / (2 * A);

            Console.WriteLine("R1 = {0:F5}", r1);
            Console.WriteLine("R2 = {0:F5}", r2);
        }
    }
*/

/*
// 1037
double valor = double.Parse(Console.ReadLine());

if (valor >= 0.0 && valor <= 25.0)
{
    Console.WriteLine("Intervalo [0,25]");
}
else if (valor > 25.0 && valor <= 50.0)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (valor > 50.0 && valor <= 75.0)
{
    Console.WriteLine("Intervalo (50,75]");
}
else if (valor > 75.0 && valor <= 100.0)
{
    Console.WriteLine("Intervalo (75,100]");
}
else
{
    Console.WriteLine("Fora de intervalo");
}
*/

/*
// 1042
string[] linha = Console.ReadLine().Split(' ');
int A = int.Parse(linha[0]);
int B = int.Parse(linha[1]);
int C = int.Parse(linha[2]);

 int[] valores = { A, B, C };
 int[] valoresOrdenados = (int[])valores.Clone();
Array.Sort(valoresOrdenados);

foreach (int valor in valoresOrdenados)
{
    Console.WriteLine(valor);
}
    Console.WriteLine();

foreach (int valor in valores)
{
    Console.WriteLine(valor);
}
*/

/*
// 1043
string[] linha = Console.ReadLine().Split(' ');
double A = double.Parse(linha[0]);
double B = double.Parse(linha[1]);
double C = double.Parse(linha[2]);

if (A + B > C && A + C > B && B + C > A)
{     
    double perimetro = A + B + C;
    Console.WriteLine("Perimetro = {0:F1}", perimetro);
} 
else 
{
    double area = ((A + B) * C) / 2;
    Console.WriteLine("Area = {0:F1}", area);
}
*/

/*
// 1044
string[] linha = Console.ReadLine().Split(' ');
double A = double.Parse(linha[0]);
double B = double.Parse(linha[1]);


if (B % A == 0 || A % B == 0)
{
    Console.WriteLine("Sao Multiplos");
} 
else
{
    Console.WriteLine("Nao sao Multiplos");
}
*/

/*
// 1046
string[] linha = Console.ReadLine().Split(' ');
int A = int.Parse(linha[0]);
int B = int.Parse(linha[1]);

int duracao;
if (A == B){
    duracao = 24;
} else if (B > A){
    duracao = B - A;
} else {
    duracao = 24 - A + B;
}
Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
*/

/*
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
*/

/*
// 1050
int ddd = int.Parse(Console.ReadLine());

if(ddd == 61)
{
    Console.WriteLine("Brasilia");
}
else if (ddd == 71)
{
    Console.WriteLine("Salvador");
}
else if (ddd == 11)
{
    Console.WriteLine("Sao Paulo");
}
else if (ddd == 21)
{
    Console.WriteLine("Rio de Janeiro");
}
else if (ddd == 32)
{
    Console.WriteLine("Juiz de Fora");
}
else if (ddd == 19)
{
    Console.WriteLine("Campinas");
}
else if (ddd == 27)
{
    Console.WriteLine("Vitoria");
}
else if (ddd == 31)
{
    Console.WriteLine("Belo Horizonte");
}
else
{
    Console.WriteLine("DDD nao cadastrado");
}
*/

/*
// 1059
for(var i = 1; i <= 100; i++){
    if(i % 2 == 0){
        Console.WriteLine(i);
    }
}
*/

/*
// 1052
int mes = int.Parse(Console.ReadLine());

if(mes == 1)
{
    Console.WriteLine("January");
} 
else if(mes == 2)
{
    Console.WriteLine("February");
}
else if(mes == 3)
{
    Console.WriteLine("March");
}
else if(mes == 4)
{
    Console.WriteLine("April");
}
else if(mes == 5)
{
    Console.WriteLine("May");
}
else if(mes == 6)
{
    Console.WriteLine("June");
}
else if(mes == 7)
{
    Console.WriteLine("July");
}
else if(mes == 8)
{
    Console.WriteLine("August");
}
else if(mes == 9)
{
    Console.WriteLine("September");
}
else if(mes == 10)
{
    Console.WriteLine("October");
}
else if(mes == 11)
{
    Console.WriteLine("November");
}
else if(mes == 12)
{
    Console.WriteLine("December");
}
*/

/*
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
*/

/*
// 1049
string tipo1 = Console.ReadLine().Trim();
string tipo2 = Console.ReadLine().Trim();
string tipo3 = Console.ReadLine().Trim();

if(tipo1 == "vertebrado")
{
    if(tipo2 == "ave")
    {
        if(tipo3 == "carnivoro")
        {
            Console.WriteLine("aguia");
        }
        else if(tipo3 == "onivoro")
        {
            Console.WriteLine("pomba");
        }
    }
    if(tipo2 == "mamifero")
    {
        if(tipo3 == "onivoro")
        {
            Console.WriteLine("homem");
        }
        else if(tipo3 == "herbivoro")
        {
            Console.WriteLine("vaca");
        }
    }
}
else if(tipo1 == "invertebrado")
{
    if(tipo2 == "inseto")
    {
        if(tipo3 == "hematofago")
        {
            Console.WriteLine("pulga");
        }
        else if(tipo3 == "herbivoro")
        {
            Console.WriteLine("lagarta");
        }
    }
    if(tipo2 == "anelideo")
    {
        if(tipo3 == "hematofago")
        {
            Console.WriteLine("sanguessuga");
        }
        else if(tipo3 == "onivoro")
        {
            Console.WriteLine("minhoca");
        }
    }
}
*/

/*
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
*/

/*
// 1065
List<double> valores = new List<double>();
double valor;

for(double i = 0; i < 5; i++)
{
    valor = double.Parse(Console.ReadLine());
    valores.Add(valor);
}

int valoresPares = 0;
foreach(double v in valores)
{
    if(v % 2 == 0)
    {
        valoresPares++;
        
    }
}
Console.WriteLine("{0} valores pares", valoresPares);
*/

/*
// 1066
List<double> valores = new List<double>();
double valor;

for(double i = 0; i < 5; i++)
{
    valor = double.Parse(Console.ReadLine());
    valores.Add(valor);
}

int valoresPar = 0;
int valoresImpar = 0;
int valoresPositivos = 0;
int valoresNegativos = 0;

foreach (int v in valores)
{
    if(v % 2 == 0)
    {
        valoresPar++;
    }
    if(v % 2 != 0)
    {
        valoresImpar++;
    }
    if(v > 0)
    {
        valoresPositivos++;
    }
    if(v < 0)
    {
        valoresNegativos++;
    }
}
Console.WriteLine("{0} valor(es) par(es)", valoresPar);
Console.WriteLine("{0} valor(es) impar(es)", valoresImpar);
Console.WriteLine("{0} valor(es) positivo(s)", valoresPositivos);
Console.WriteLine("{0} valor(es) negativo(s)", valoresNegativos);
*/

/*
// 1070
int X = int.Parse(Console.ReadLine());

if(X % 2 == 0)
{
    X++;
}

for(int i = 0; i < 6; i++)
{
    Console.WriteLine(X);
    X += 2;
}
*/

/*
// 1078
int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    int resultado = i * N;
    Console.WriteLine("{0} x {1} = {2}", i, N, resultado);
}
*/

/*
// 1067
int x = int.Parse(Console.ReadLine());

for(int i = 1; i <= x; i++)
{
    if(i % 2 != 0)
    {
        Console.WriteLine(i);
    } 
}
*/

/*
//1074
List<string> resultados = new List<string>();
double qntValores = double.Parse(Console.ReadLine());

double valor;

for(int i = 0; i < qntValores; i++)
{
    valor = double.Parse(Console.ReadLine());

    if(valor % 2 == 0 && valor > 0)
    {
        resultados.Add("EVEN POSITIVE");
    }
    else if(valor % 2 == 0 && valor < 0)
    {
        resultados.Add("EVEN NEGATIVE");
    }
    else if(valor % 2 != 0 && valor > 0)
    {
        resultados.Add("ODD POSITIVE");
    }
    else if(valor % 2 != 0 && valor < 0)
    {
        resultados.Add("ODD NEGATIVE");
    }
    else if(valor == 0)
    {
        resultados.Add("NULL");
    }
}

foreach (string resultado in resultados)
{
    Console.WriteLine(resultado);
}
*/

/*
// 1064
 double soma = 0;
 int numerosPositivos = 0;

for(int i = 0; i < 6; i++)
{
    double valor = double.Parse(Console.ReadLine());

    if(valor > 0)
    {
        soma += valor;
        numerosPositivos++;
    }
}
if(numerosPositivos > 0)
{
    double media = soma / numerosPositivos;
    Console.WriteLine("{0} valores positivos", numerosPositivos);
    Console.WriteLine("{0:F1}", media);
}
*/

/*
// 1072
int quantidadeValores = int.Parse(Console.ReadLine());
double valores;
int valoresIn = 0;
int valoresOut = 0;

for(int i = 0; i < quantidadeValores; i++)
{
    valores = double.Parse(Console.ReadLine());

    if(valores >= 10 && valores <= 20)
    {
        valoresIn++;
    }
    if(valores < 10 || valores > 20)
    {
        valoresOut++;
    }
}
Console.WriteLine("{0} in", valoresIn);
Console.WriteLine("{0} out", valoresOut);
*/

/*
// 1061
string[] inicioDia = Console.ReadLine().Split(' ');
string[] inicioHora = Console.ReadLine().Split(':');
string[] fimDia = Console.ReadLine().Split(' ');
string[] fimHora = Console.ReadLine().Split(':');

int diaInicio = int.Parse(inicioDia[1]);
int horaInicio = int.Parse(inicioHora[0]);
int minutoInicio = int.Parse(inicioHora[1]);
int segundoInicio = int.Parse(inicioHora[2]);

int diaFim = int.Parse(fimDia[1]);
int horaFim = int.Parse(fimHora[0]);
int minutoFim = int.Parse(fimHora[1]);
int segundoFim = int.Parse(fimHora[2]);

int inicioEmSegundos = segundoInicio + minutoInicio * 60 + horaInicio * 3600 + diaInicio * 86400;
int fimEmSegundos = segundoFim + minutoFim * 60 + horaFim * 3600 + diaFim * 86400;

int duracaoEmSegundos = fimEmSegundos - inicioEmSegundos;

int dias = duracaoEmSegundos / 86400;
duracaoEmSegundos %= 86400;
int horas = duracaoEmSegundos / 3600;
duracaoEmSegundos %= 3600;
int minutos = duracaoEmSegundos / 60;
int segundos = duracaoEmSegundos % 60;

Console.WriteLine("{0} dia(s)", dias);
Console.WriteLine("{0} hora(s)", horas);
Console.WriteLine("{0} minuto(s)", minutos);
Console.WriteLine("{0} segundo(s)", segundos);
*/

/*
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
*/

/*
// 1113
while(true)
{
string[] linha = Console.ReadLine().Split(" ");
int X = int.Parse(linha[0]);
int Y = int.Parse(linha[1]);

if(X == Y)
{
    break;
}
else if(X < Y)
{
     Console.WriteLine("Crescente");
}
else
{
     Console.WriteLine("Decrescente");
}
}
*/

/*
// 1114
while(true)
{
    int senha = int.Parse(Console.ReadLine());

    if(senha == 2002)
    {
       Console.WriteLine("Acesso Permitido");
       break;
    }
    else{
        Console.WriteLine("Senha Invalida");
    }
}
*/

/*
// 1116
while(true)
{
int numeroDeCasos = int.Parse(Console.ReadLine());

for(int i = 0; i < numeroDeCasos; i++)
{
    string[] linha = Console.ReadLine().Split(" ");
    int A = int.Parse(linha[0]);
    int B = int.Parse(linha[1]);
    
    if(A < 0)
    {
        Console.WriteLine("divisao impossivel");
    } else
    {
        double resultado = A / B;
        Console.WriteLine("{0:F1}", resultado);
    }
}
}
*/

/*
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
*/

/*
// 1099
int numeroDeCasos = int.Parse(Console.ReadLine());
int[] resultados = new int[numeroDeCasos];

for (int i = 0; i < numeroDeCasos; i++)
{
    string[] numeros = Console.ReadLine().Split(" ");
    int X = int.Parse(numeros[0]);
    int Y = int.Parse(numeros[1]);

    if (X > Y)
    {
        int temp = X;
        X = Y;
        Y = temp;
    }

    int somaDeImpares = 0;

    for (int z = X + 1; z < Y; z++)
    {
        if (z % 2 != 0) 
        {
            somaDeImpares += z;
        }
    }
    resultados[i] = somaDeImpares;
}

for(int i = 0; i < numeroDeCasos; i++)
{
    Console.WriteLine(resultados[i]);
}
*/

/*
// 1132
List<int> somaDosNumeros = new List<int>();

int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

for(int i = X; i <= Y; i++)
{
    if(i  % 13  != 0)
    {
        somaDosNumeros.Add(i);
    }
}

int soma = somaDosNumeros.Sum();

Console.WriteLine(soma);
*/

/*
// 1924
int numeroDeCasos = int.Parse(Console.ReadLine());

for(int i = 0; i < numeroDeCasos; i++)
{
    string nomeDoCurso = Console.ReadLine();
}

Console.WriteLine("Ciencia da Computacao");
*/

/*
// 2006
int tipoDoCha = int.Parse(Console.ReadLine());

string[] participantes = Console.ReadLine().Split(" ");
int A = int.Parse(participantes[0]);
int B = int.Parse(participantes[1]);
int C = int.Parse(participantes[2]);
int D = int.Parse(participantes[3]);
int E = int.Parse(participantes[4]);

int acertos = 0;

if(A == tipoDoCha)
acertos++;
if(B == tipoDoCha)
acertos++;
if(C == tipoDoCha)
acertos++;
if(D == tipoDoCha)
acertos++;
if(E == tipoDoCha)
acertos++;

Console.WriteLine(acertos);
*/

/*
// 2060
int quantidadeDeCasos = int.Parse(Console.ReadLine());

string[] valores = Console.ReadLine().Split();

int multiplosDe2 = 0;
int multiplosDe3 = 0;
int multiplosDe4 = 0;
int multiplosDe5 = 0;

for(int i = 0; i < quantidadeDeCasos; i++)
{
    int valor = int.Parse(valores[i]);

    if(valor % 2 == 0) multiplosDe2++;
    if(valor % 3 == 0) multiplosDe3++;
    if(valor % 4 == 0) multiplosDe4++;
    if(valor % 5 == 0) multiplosDe5++;

}

Console.WriteLine("{0} Multiplo(s) de 2", multiplosDe2);
Console.WriteLine("{0} Multiplo(s) de 3", multiplosDe3);
Console.WriteLine("{0} Multiplo(s) de 4", multiplosDe4);
Console.WriteLine("{0} Multiplo(s) de 5", multiplosDe5);
*/

/*
// 3303
string palavra = Console.ReadLine();

if(palavra.Length < 10)
{
    Console.WriteLine("palavrinha");
} else{
    Console.WriteLine("palavrao");
}
*/

/*
// 3040
int numeroDeCasos = int.Parse(Console.ReadLine());

for(int i = 0; i < numeroDeCasos; i++)
{
    string[] linha = Console.ReadLine().Split(" ");

    int altura = int.Parse(linha[0]);
    int diametro = int.Parse(linha[1]);
    int QuantidadeDeGalhos = int.Parse(linha[2]);

    if((altura >= 200 && altura <= 300) && (diametro >= 50) && (QuantidadeDeGalhos >= 150))
    {
        Console.WriteLine("Sim");
    } else 
    {
        Console.WriteLine("Nao");
    }
}
*/

/*
// 3091
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

int resposta = A % B;

Console.WriteLine("{0}", resposta);
*/

/*
// 3146
double raio = double.Parse(Console.ReadLine());

double resultado = (2 * 3.14) * raio;

Console.WriteLine("{0:F2}", resultado);
*/

/*
// 3157
string texto = Console.ReadLine();

string novoTexto = "Nao se refuta ciencia com opiniao";
texto = novoTexto;

Console.WriteLine(texto);
*/

/*
// 2861
int numeroDeCasos = int.Parse(Console.ReadLine());

for(int  i = 0; i < numeroDeCasos; i++)
{
    string pergunta = Console.ReadLine();

    string resposta = "gzuz";

    pergunta = resposta;

    Console.WriteLine(pergunta);
}
*/

/*
// 2862
int numeroDeCasos = int.Parse(Console.ReadLine());

for(int i = 0; i < numeroDeCasos; i++)
{
    int nivelDeEnergia = int.Parse(Console.ReadLine());

    if(nivelDeEnergia > 8000)
    {
        Console.WriteLine("Mais de 8000!");
    } 
    else 
    {
        Console.WriteLine("Inseto!");
    }
}
*/