// Exercício 2
// Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
// cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
// Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
// exemplo, bubble sort) para ordenar os nomes.

string[] listaNomes = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome do usuário {i + 1}:");
    listaNomes[i] = Console.ReadLine()!;
};


Array.Sort(listaNomes);

foreach (var item in listaNomes)
{
    Console.WriteLine(item);
}