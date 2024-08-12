//Condicionais

// Console.WriteLine("Informe a primeira nota:");
// float nota1 = float.Parse(Console.ReadLine());

// Console.WriteLine("Informe a segunda nota:");
// float nota2 = float.Parse(Console.ReadLine());

// Console.WriteLine("Informe a terceira nota:");
// float nota3 = float.Parse(Console.ReadLine());

// float media = ((nota1 + nota2 + nota3) / 3);

//     if(media > 5)
//     {
//          Console.WriteLine($"O aluno com a {media} está Aprovado");
//     }
//     else if(media == 5)
//     {
//          Console.WriteLine($"O aluno com a {media} está Recuperação");
//     }
//     else
//     {
//          Console.WriteLine($"O aluno com a {media} está Reprovado");
//     }

//For:

// Console.WriteLine("Escolha um número para imprimimos a sua tabuada!");
// int n = Convert.ToInt32(Console.ReadLine()!);

// for(int x = 0; x < 11; x++)
// {
//      Console.WriteLine(

//           $"| {n} x {x} = { n * x }|"

//           );
// }

//While

// int contador = 1;
// int soma = 0 ;
// while(contador <= 100)
// {
//      if (contador % 2 == 0)
//      {
//           soma += contador;
//      }
//      contador++;

// }
//      Console.WriteLine(soma);

//do while

// using System.Security.Cryptography;

// int tentativa = 0;
// int chute = 0;
// int numeroA = RandomNumberGenerator.GetInt32(1, 100);
// do
// {
//      Console.ForegroundColor = ConsoleColor.White;
//      Console.WriteLine("Tente adivinhar o numero de 1 a 100");
//      chute = Convert.ToInt32(Console.ReadLine()!);
//      tentativa ++;
//      if (chute != numeroA)
//      {
//           Console.ForegroundColor = ConsoleColor.Red;
//           Console.WriteLine(chute > numeroA ? "O chute foi maior do que o numero! Tente novamente!" : "O chute foi menor do que o numero! Tente novamente!");
//      }
     
      
// }    
// while (chute != numeroA);
// Console.ForegroundColor = ConsoleColor.Green;
// Console.ResetColor();
// Console.WriteLine($"Tentativas: {tentativa}");

// Exercício:

// 5) Você vai criar um programa que armazena as notas de vários alunos em diferentes disciplinas. O programa deve calcular a média de cada aluno e determinar quais alunos têm médias acima de 7.0 (aprovados) e quais têm médias abaixo de 7.0 (reprovados). O programa deve usar foreach para iterar sobre as coleções de alunos e suas notas.

// Especificações:

// - Armazene as notas de 3 disciplinas para cada aluno.
// - Calcule a média de cada aluno.
// - Exiba a média e o status (aprovado/reprovado) de cada aluno.
// - Use foreach para iterar sobre os alunos e as disciplinas.

// List<int> listaNotas = [];


// Console.WriteLine("Digite o nome do primeiro aluno");
// string aluno1 = Console.ReadLine()!;
// Console.WriteLine("Digite o nome do segundo aluno");
// string aluno2 = Console.ReadLine()!;
// Console.WriteLine("Digite o nome do terceiro aluno");
// string aluno3 = Console.ReadLine()!;

// Console.WriteLine("Digite a nota de Matemática do primeiro aluno");
// int notaA1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite a nota de Português do primeiro aluno");
// int notaA2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite a nota de História do primeiro aluno");
// int notaA3 = Convert.ToInt32(Console.ReadLine());

// int media1 = (notaA1 + notaA2 + notaA3) / 3;
// listaNotas.Add(media1);

// Console.WriteLine("Digite a nota de Matemática do segundo aluno");
// int notaB1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite a nota de Português do segundo aluno");
// int notaB2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite a nota de História do segundo aluno");
// int notaB3 = Convert.ToInt32(Console.ReadLine());

// int media2 = (notaB1 + notaB2 + notaB3) / 3;
// listaNotas.Add(media2);

// Console.WriteLine("Digite a nota de Matemática do terceiro aluno");
// int notaC1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite a nota de Português do terceiro aluno");
// int notaC2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite a nota de História do terceiro aluno");
// int notaC3 = Convert.ToInt32(Console.ReadLine());

// int media3 = (notaC1 + notaC2 + notaC3) / 3;
// listaNotas.Add(media3);

// foreach (int nota in listaNotas)
// {
     
//      Console.ForegroundColor = ConsoleColor.White;
//      Console.WriteLine($"o aluno {aluno1} ficou com media {listaNotas[0]} e está");
//      Console.WriteLine(listaNotas[0] >= 7 ? "Aprovado" : "Reprovado");
//      Console.WriteLine($"o aluno {aluno2} ficou com media {listaNotas[1]} e está");
//      Console.WriteLine(listaNotas[1] >= 7 ? "Aprovado" : "Reprovado");
//      Console.WriteLine($"o aluno {aluno3} ficou com media {listaNotas[2]} e está");
//      Console.WriteLine(listaNotas[2] >= 7 ? "Aprovado" : "Reprovado");
//      break;
//      // Console.WriteLine(nota);
// }