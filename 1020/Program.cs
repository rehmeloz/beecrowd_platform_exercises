// 1020
int idadeDias = int.Parse(Console.ReadLine());

int idadeAnos = idadeDias / 365;
int diasRestantes = idadeDias % 365;
int idadeMeses = diasRestantes  / 30;
int idadeDiasRestantes =  diasRestantes % 30;

Console.WriteLine("{0} ano(s)", idadeAnos);
Console.WriteLine("{0} mes(es)", idadeMeses);
Console.WriteLine("{0} dia(s)", idadeDiasRestantes);
