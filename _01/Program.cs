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