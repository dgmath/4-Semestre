// Exercício 1
// Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o
// número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.

Console.WriteLine("Insira um numero para verificar se ele é par ou ímpar:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Ímpar");
    
}