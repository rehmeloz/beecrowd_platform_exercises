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