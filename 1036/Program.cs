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