// See https://aka.ms/new-console-template for more information
// Exercício 5
// Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada
// letra do alfabeto aparece no texto.

string[] alfabetoArray = "a b c d e f g h i j k l m n o p q r s t u v w x y z".Split(" ");

Console.WriteLine($"Digite um texto a ser analizado");
string texto = Console.ReadLine()!.Trim();

if(texto == ""){
    Console.WriteLine($"Nenhum texto foi digitado");
}

Console.WriteLine($"");
int loop = 0;
foreach(string letrasAlfabeto in alfabetoArray){
    int letras = 0;

    foreach(char caractereLetra in texto){
        if(letrasAlfabeto.Equals(caractereLetra.ToString().ToLower())){
            letras++;
        }
    }

    if(letras > 0){
        Console.WriteLine($"{letrasAlfabeto} = {letras}");
        loop++;
    }
}