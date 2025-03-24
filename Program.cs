Console.WriteLine("Digite seu nome completo");

string nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}!");

Console.WriteLine("Qual seu ano de nascimento?");
int anoDeNascimento = int.Parse(Console.ReadLine());
DateTime dataAtual = DateTime.Now;
int idade = dataAtual.Year - anoDeNascimento;
Console.WriteLine($"Você tem {idade} anos.");
Console.WriteLine("Seu codigo unicode é: ");
foreach (char letra in nome)
{
    Console.Write((int)letra + " ");
}
