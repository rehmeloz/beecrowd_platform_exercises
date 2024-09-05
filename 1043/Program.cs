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