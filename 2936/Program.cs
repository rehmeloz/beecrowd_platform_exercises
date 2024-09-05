// 2936
int qtdCurupira = int.Parse(Console.ReadLine());
int qtdBoitata = int.Parse(Console.ReadLine());
int qtdBoto = int.Parse(Console.ReadLine());
int qtdMapinguari = int.Parse(Console.ReadLine());
int qtdIara = int.Parse(Console.ReadLine());

int valorCurupira = qtdCurupira * 300;
int valorBoitata = qtdBoitata * 1500;
int valorBoto = qtdBoto * 600;
int valorMapinguari = qtdMapinguari * 1000;
int valorIara = qtdIara * 150;

int resultadoEmGramas = valorCurupira + valorBoitata + valorBoto + valorMapinguari + valorIara + 225;

Console.WriteLine(resultadoEmGramas);