// 1013
string[] linha = Console.ReadLine().Split(' ');
int A = int.Parse(linha[0]);
int B = int.Parse(linha[1]);
int C = int.Parse(linha[2]);

int maiorAB = (A + B + Math.Abs(A - B)) / 2;
int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;
       
Console.WriteLine("{0} eh o maior", maiorABC);