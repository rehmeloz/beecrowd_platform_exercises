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