// Exercício 3
// Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.
// Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar
// os números pares.

int[] listaNumeros = [10, 5, 2, 6, 3, 8, 9, 33, 44, 99]; 

int somaPares = 0;

for (int i = 0; i < listaNumeros.Length; i++)
{
    if (listaNumeros[i] % 2 == 0)
    {
        somaPares += listaNumeros[i];
    }
}

Console.WriteLine(somaPares);