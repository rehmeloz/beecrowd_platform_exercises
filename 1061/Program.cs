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