// Receba 4 notas, com somente uma casa decimal. Valide se todas estão entre 0.0 e 10.0.

double media;
string resultado;

Console.WriteLine("--- Calculo para Prof ---\n");

Console.Write("Digite a primeira nota.....: ");
double nota1 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a segunda nota......: ");
double nota2 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a terceira nota.....: ");
double nota3 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a quarta nota.......: ");
double nota4 = double.Parse(Console.ReadLine()!);

if (nota1 < 0.0 || nota1 > 10.0 ||
    nota2 < 0.0 || nota2 > 10.0 ||
    nota3 < 0.0 || nota3 > 10.0 ||
    nota4 < 0.0 || nota4 > 10.0) {
    Console.WriteLine("Digite somente notas entre 0 e 10.");
} else {
    media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine($"Você ficou com média {media:N1}.");

if ( media < 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    resultado = "Reprovado";
} else if (media > 6)
{
    Console.ForegroundColor = ConsoleColor.Green;
    resultado = "Aprovado";
} else {
    Console.ForegroundColor = ConsoleColor.Blue;
    resultado = "Em recuperação";
}
Console.Write($"Resultado: {resultado}");
}
Console.ForegroundColor = ConsoleColor.Black;
