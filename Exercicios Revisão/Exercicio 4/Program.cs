// Exercício 4
// Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
// número até o número 10. Utilize um laço for para gerar os múltiplos do número.

Console.WriteLine($"Bem vindo(a) a tabuada");
Console.WriteLine($"Escolha um número");
int numeroEscolhido = int.Parse(Console.ReadLine()!);



void Tabuada(int numero)
{
    for (int i = 0; i < 11; i++)
    {
        Console.WriteLine($"{numeroEscolhido} X {i} = {numeroEscolhido * i}");
        
    }
}

Tabuada(numeroEscolhido);