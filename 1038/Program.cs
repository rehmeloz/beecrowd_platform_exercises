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