// 13) Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.
// using System;
// using System.Collections;
// namespace Exercio13PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             (int A, int B, int C) = Obtervalores();
//             ExibirValores(A,B,C);
//         }
//         private static (int,int,int) Obtervalores()
//         {
//             Console.WriteLine("Digite o valor do primeiro número:");
//             int A = int.Parse(Console.ReadLine());
//             Console.WriteLine("Digite o valor do segundo número:");
//             int B = int.Parse(Console.ReadLine());
//             Console.WriteLine("Digite o valor do terceiro número:");
//             int C = int.Parse(Console.ReadLine());

//             return (A, B, C);
//         }
//         private static void ExibirValores(int A, int B, int C)
//         {
//             int[] Valores = [A,B,C];
//             Array.Sort(Valores);
//             Array.Reverse(Valores);

//             Console.WriteLine("Valores em ordem decrecente");

//             foreach (int valor in Valores)
//             {
//                 Console.WriteLine(valor);
//             }
//         }
//     }
// }

// // 14) Escreva um programa que leia dois números e apresente a diferença do maior para o menor. 
// using System;
// namespace Exercio14PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             (int A, int B ) = ObterValores();
//             exibirInfo(A,B);
//         }
//         private static (int, int) ObterValores()
//         {
//              Console.WriteLine("Digite o valor do primeiro número:");
//             int A = int.Parse(Console.ReadLine());
//             Console.WriteLine("Digite o valor do segundo número:");
//             int B = int.Parse(Console.ReadLine());

//             return (A,B);
//         }
//         private static void exibirInfo(int A, int B)
//         {
//             int exibirDif = A > B ? A - B : B - A; // A > B ? if true A-B (: else ) B - A
//             Console.WriteLine ($"A difereça é de {exibirDif}");
//         }
//     }
// }


//15) Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi
// aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota
// do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
// apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado,
// apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do
// aluno. 
// using System;
// using System.Threading;
// namespace Exercio15PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             bool continuar = true;
//             while (continuar)
//             {
//                 (int A, int B, int C, int D) = obterValores();
//                 int media = obterMedia(A, B, C, D);

//                 if (media < 7)
//                 {
//                     Console.WriteLine("Você não obteve a média\nInsira a nota da recuperação para obter uma nova média");
//                     int notaRecuperacao = obterNotaRecuperacao();
//                     int mediaNova = obterMediaAtualizada(media, notaRecuperacao);
//                     exibirInfoAtualizada(mediaNova);
//                 }
//                 else
//                 {
//                     Console.WriteLine("Parabéns você foi aprovado!");
//                     aguardarLimparTela();
//                 }

//                 Console.WriteLine("Digite S para continuar ou qualquer outra tecla para encerrar");
//                 continuar = Console.ReadLine().Trim().ToUpper() == "S";
//             }
//         }
//         private static void aguardarLimparTela()
//         {
//             Thread.Sleep(2000);
//             Console.Clear();
//         }
//         private static void exibirInfoAtualizada(int novaMedia)
//         {
//             if (novaMedia >= 7)
//             {
//                 Console.Write($"Parabéns sua nova nota é {novaMedia} e foi o suficiente para passar!");
//             }
//             else
//             {
//                 Console.WriteLine("Tu rodou mané!");
//                 aguardarLimparTela();
//             }
//         }
//         private static int obterMediaAtualizada(int media, int notaRecuperacao)
//         {
//             return (media + notaRecuperacao) / 2;
//         }
//         private static int obterNotaRecuperacao()
//         {
//             return obterNotas("da recuperação");
//         }
//         private static int obterMedia(int A, int B, int C, int D)
//         {
//             return (A + B + C + D) / 4;
//         }
//         private static (int, int, int, int) obterValores()
//         {
//             int A = obterNotas("do primeiro bimestre");
//             int B = obterNotas("do segundo bimestre");
//             int C = obterNotas("do terceiro bimestre");
//             int D = obterNotas("do quarto bimestre");

//             return (A, B, C, D);
//         }
//         private static int obterNotas(string notaRef)
//         {
//             int nota;
//             string input;
//             bool sucesso;

//             do
//             {
//                 Console.WriteLine($"Digite a nota {notaRef}");
//                 input = Console.ReadLine();
//                 sucesso = int.TryParse(input, out nota);
//                 Console.Clear();

//                 if (!sucesso)
//                 {
//                     Console.WriteLine("Atenção!\nDigite um valor numérico válido");
//                     aguardarLimparTela();
//                 }
//             }
//             while (!sucesso);

//             return nota;
//         }
//     }
// }

// 16) Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do
// menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.
// using System;

// namespace Exercicio16PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             (int A, int B) valor = obterValor();
//             exibirResultado(valor.A, valor.B);
//         }

//         private static (int, int) obterValor()
//         {
//             int A = ObterValoresValidos("primeiro");
//             int B = ObterValoresValidos("segundo");

//             return (A, B);
//         }
//         private static int ObterValoresValidos(string valorRef)
//         {
//             int numero;
//             string input;
//             bool verificação;

//             do
//             {
//                 Console.WriteLine($"Digite o {valorRef} número");
//                 input = Console.ReadLine();
//                 verificação = int.TryParse(input, out numero);
//                 if (!verificação)
//                 {
//                     Console.WriteLine("Atenção\nDigite um valor numérico válido!");
//                 }
//             }
//             while (!verificação);

//             return numero;
//         }

//         private static void exibirResultado(int A, int B)
//         {
//             if (A > B)
//             {
//                 Console.WriteLine($"O maior número é {A} e o menor número é {B}.");
//             }
//             else if (A < B)
//             {
//                 Console.WriteLine($"O maior número é {B} e o menor número é {A}.");
//             }
//             else
//             {
//                 Console.WriteLine("Os dois números são iguais.");
//             }
//         }
//     }
// }


// 17) Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa
// entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
// Caso contrário, apresentar a mensagem “valor inválido”. 

// using System;
// namespace Exercicio17PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             int numero = obterNumero();
//             if (numero >= 0 || numero <= 9)
//             {
//                 Console.WriteLine("Está na faixa de 0 até 9");
//             }
//             else
//             {
//                 Console.WriteLine("Fugiu dos limtes requisitados");
//             }
//         }
//          private static void aguardarLimparTela()
//         {
//             Thread.Sleep(2000);
//             Console.Clear();
//         }
//         public static int obterNumero()
//         {
//             string input;
//             bool valido;
//             int numero;

//             do
//             {
//                 Console.WriteLine("Digite um numero");
//                 input = Console.ReadLine();
//                 valido = int.TryParse(input, out numero);
//                 if (!valido)
//                 {
//                     Console.WriteLine("Digite um numero valido !");
//                     aguardarLimparTela();
//                 }
//             }
//             while (!valido);

//             return numero;
//         }
//     }
// }

// 18) Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou
// igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é
// um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou
// seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar o comando Switch).

// using System;
// namespace Exercicio18PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             int A = obterNumero();
//             exibirInfo(A);
//         }
//         private static void exibirInfo(int A)
//         {
//             switch (A)
//             {
//                 case 1:
//                     Console.WriteLine ("Valor do numero digitado é UM");
//                     break;
//                 case 2:
//                     Console.WriteLine ("Valor do número digitado é DOIS");
//                     break;
//                 case 3:
//                     Console.WriteLine ("Valor do número digitado é TRÊS");
//                     break;
//                 default:
//                     Console.WriteLine ("Código invalido ou excedeu os limites requisitados");
//                 break;
//             }
//         } 
//          private static int obterNumero()
//         {
//             string input;
//             bool valido;
//             int numero;

//             do
//             {
//                 Console.WriteLine("Digite um numero");
//                 input = Console.ReadLine();
//                 valido = int.TryParse(input, out numero);
//                 if (!valido)
//                 {
//                     Console.WriteLine("Digite um numero valido");
//                     aguardarLimparTela();
//                 }
//             }
//             while (!valido);

//             return numero;
//         }
//          private static void aguardarLimparTela()
//         {
//             Thread.Sleep(2000);
//             Console.Clear();
//         }
//     }
// }

// 19) Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada
// lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é
// eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso
// contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a
// ocorrência.

// using System;

// namespace Exercicio19PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             (int A, int B, int C) = ObterValores();
//             VerificarTipoTriangulo(A, B, C);
//         }

//         private static (int, int, int) ObterValores()
//         {
//             int A = ObterValorValido("primeiro");
//             int B = ObterValorValido("segundo");
//             int C = ObterValorValido("terceiro");

//             return (A, B, C);
//         }

//         private static int ObterValorValido(string valorRef)
//         {
//             int numero;
//             string input;
//             bool verificacao;

//             do
//             {
//                 Console.WriteLine($"Digite o {valorRef} valor para o lado do triângulo:");
//                 input = Console.ReadLine();
//                 verificacao = int.TryParse(input, out numero);
//                 if (!verificacao || numero <= 0)
//                 {
//                     Console.WriteLine("Atenção\nDigite um valor numérico válido e maior que zero!");
//                 }
//             }
//             while (!verificacao || numero <= 0);

//             return numero;
//         }

//         private static void VerificarTipoTriangulo(int A, int B, int C)
//         {
//             if (EhTriangulo(A, B, C))
//             {
//                 string tipo = DeterminarTipoTriangulo(A, B, C);
//                 Console.WriteLine($"O triângulo é {tipo}.");
//             }
//             else
//             {
//                 Console.WriteLine("Os valores fornecidos não caracterizam um triângulo.");
//             }
//         }

//         private static bool EhTriangulo(int A, int B, int C)
//         {
//             return A < B + C && B < A + C && C < A + B;
//         }

//         private static string DeterminarTipoTriangulo(int A, int B, int C)
//         {
//             if (A == B && B == C)
//             {
//                 return "equilátero";
//             }
//             else if (A == B || A == C || B == C)
//             {
//                 return "isósceles";
//             }
//             else
//             {
//                 return "escaleno";
//             }
//         }
//     }
// }

// 20) Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada
// variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido
// multiplicado pelo maior e o maior valor dividido pelo menor.

// using System;
// namespace Exercicio20PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             (int A, int B, int C) = obterValores();
//             mostrarInfo(A,B,C);
//         }
//         private static void mostrarInfo(int A, int B, int C)
//         {
//             int menor = Math.Min(A,Math.Min(B, C));
//             int maior = Math.Max(A,Math.Max(B,C));
//             double maiorDivPMenor = (double)maior / menor;
//             Console.WriteLine($"O menor valor foi {menor}\nO maior foi {maior}\n\n\nO menor valor lido multiplicado pelo maior é :{menor * maior}\nO maior valor lido dividio pelo menor é :{maiorDivPMenor}");
//         }
//         private static (int, int, int) obterValores()
//         {
//             int A = verificarValido("A");
//             int B = verificarValido("B");
//             int C = verificarValido("C");
//             return (A, B, C);
//         }
//         private static int verificarValido (string refTip)
//         {
//             string input;
//             int retorno;
//             bool valido;

//             do
//             {
//                 Console.WriteLine($"Digite um valor maior que zero para ser armazenado em; {refTip}!");
//                 input = Console.ReadLine();
//                 valido = int.TryParse(input, out retorno);
//                 aguardarLimparTela();
//                 if (retorno < 0 )
//                 {
//                     Console.WriteLine("Valor menor que zero\nTente novamente !");
//                     aguardarLimparTela();
//                 }
//                 else if (!valido)
//                 {
//                     Console.WriteLine ("Valor invalido\nDigite um valor numérico valido...");
//                     aguardarLimparTela();
//                 }
//             } while (!valido);

//             return retorno;
//         }
//         private static void aguardarLimparTela()
//         {
//             Thread.Sleep(200);
//             Console.Clear();
//         }
//     }
// }

// 21) Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é
// positivo ou negativo. Pare a execução do programa quando o usuário requisitar.
// using System;
// using System.Security.Cryptography;
// namespace Exercicio21PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             bool continuar;
//             do
//             {
//                 Console.Clear();
//                 int A = obterValor();
//                 exibirInfo(A);
//                 Console.WriteLine("Digite S caso queira continuar e qualquer outra tecla para encerrar !");
//                 continuar = Console.ReadLine().Trim().ToUpper() == "S";
//             } while (continuar);
//             Console.WriteLine("Programa encerrado...");
//         }
//         private static void exibirInfo(int A)
//         {
//             {
//                     if (A > 0)
//                 {
//                     Console.WriteLine("Valor é positivo");
//                 }
//                 else if (A < 0 )
//                 {
//                     Console.WriteLine("Valor é negativo");
//                 }
//                 else 
//                 {
//                     Console.WriteLine("O valor é neutro");
//                 }
//             } 
//         }
//         private static int obterValor()
//         {
//             int A = obterValorValido("A");
//             return A;
//         }
//         private static int obterValorValido(string valorRef)
//         {
//             int numero;
//             string input;
//             bool valido;
//             do
//             {
//                 Console.WriteLine($"Insira o valor de {valorRef}");
//                 input = Console.ReadLine();
//                 valido = int.TryParse(input, out numero);
//                 if (!valido)
//                 {
//                     Console.WriteLine("Digite um valor numerico valido");
//                 }
//             } while (!valido);

//             return numero;
//         }
//     }
// }


// 22) Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o
// resultado.
// using System;
// using System.Security.Cryptography;
// namespace Exercicio22PDF2
// {
//     public static class Program
//     {         public static void Main()
//         {
//             int N = obterValor();
//             (int B, int A) = armazenar(N);
//             exibirInfo(A,B);

//         }
//         private static void exibirInfo(int A, int B)
//         {
//             if ( A != 0)
//             {
//                 Console.WriteLine($"O valor armazenado em A foi: {A}");
//             }
//             else if (B != 0)
//             {
//                 Console.WriteLine($"O valor armazenado em B foi: {B}");
//             }
//             else
//             {
//                 Console.WriteLine("O valor armazenado foi 0 portanto ele não será salva em A ou B pois se trata de um numero neutro !");
//             }
//         }
//         private static (int, int) armazenar(int N)
//         {
//             int A = 0;
//             int B = 0;

//             if (N < 0)
//             {
//                  A = N;
//             }
//             else if (N > 0)
//             {
//                  B = N;
//             }
//             return (A, B);
//         }
//         private static int obterValor()
//         {
//             return obterValorValido("N");
//         }
//         private static int obterValorValido(string valorRef)
//         {
//             int numero;
//             string input;
//             bool valido;
//             do
//             {
//                 Console.WriteLine($"Insira o valor de {valorRef}");
//                 input = Console.ReadLine();
//                 valido = int.TryParse(input, out numero);
//                 if (!valido)
//                 {
//                     Console.WriteLine("Digite um valor numerico valido");
//                 }
//             } while (!valido);

//             return numero;
//         }
//     }
// }

// 24) Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja
// realizar:
// 1 – Verificar se um dos números lidos é ou não múltiplo do outro
// 2 – Verificar se os dois números lidos são pares
// 3 – Verificar se a média dos dois números é maior ou igual a 7.
// 4 – Sair 
// using System;
// namespace Exercicio24PDF2
// {
//     public static class Program
//     {
//         enum Menu { Multiplo = 1, Pares, Media, Sair }

//         public static void Main()
//         {
//             bool escolheuSair = false;
//             while (!escolheuSair)
//             {
//                 menuEstrutura();
//                 int OpcInt = int.Parse(Console.ReadLine());
//                 Menu OpcMenu = (Menu)OpcInt;
//                 if (OpcMenu != Menu.Sair)
//                 {
//                     (int A, int B) = obterValores();
//                     switch (OpcMenu)
//                     {
//                         case Menu.Multiplo:
//                             eMultiplo(A, B);
//                             break;
//                         case Menu.Pares:
//                             ePar(A, B);
//                             break;
//                         case Menu.Media:
//                             mediaMaiorQue7(A, B);
//                             break;
//                         default:
//                             Console.WriteLine("Opção inválida");
//                             break;
//                     }
//                 }
//                 else
//                 {
//                     escolheuSair = true;
//                 }
//             }
//         }

//         private static void mediaMaiorQue7(int A, int B)
//         {
//             double media = (A + B) / 2.0;
//             if (media == 7)
//             {
//                 Console.WriteLine("A média é 7");
//             }
//             else if (media > 7)
//             {
//                 Console.WriteLine("A média é maior que 7");
//             }
//             else
//             {
//                 Console.WriteLine("A média é menor que 7");
//             }
//         }

//         private static void ePar(int A, int B)
//         {
//             if (A % 2 == 0 && B % 2 == 0)
//             {
//                 Console.WriteLine("A e B são pares");
//             }
//             else if (A % 2 == 0)
//             {
//                 Console.WriteLine("Apenas A é par");
//             }
//             else if (B % 2 == 0)
//             {
//                 Console.WriteLine("Apenas B é par");
//             }
//             else
//             {
//                 Console.WriteLine("Nenhum dos números é par");
//             }
//         }

//         private static void eMultiplo(int A, int B)
//         {
//             if (B != 0 && A % B == 0)
//             {
//                 Console.WriteLine("A é múltiplo de B");
//             }
//             else if (A != 0 && B % A == 0)
//             {
//                 Console.WriteLine("B é múltiplo de A");
//             }
//             else
//             {
//                 Console.WriteLine("Nenhum é múltiplo do outro");
//             }
//         }

//         private static (int, int) obterValores()
//         {
//             int A = ObterValoresValidos("de A");
//             int B = ObterValoresValidos("de B");
//             return (A, B);
//         }

//         private static void menuEstrutura()
//         {
//             Console.WriteLine("[1] Verificar se é múltiplo\n[2] Verificar se são pares\n[3] Verificar se média é maior que 7\n[4] Sair");
//         }

//         private static int ObterValoresValidos(string valorRef)
//         {
//             int numero;
//             string input;
//             bool valido;
//             do
//             {
//                 Console.WriteLine($"Digite o valor {valorRef}:");
//                 input = Console.ReadLine();
//                 valido = int.TryParse(input, out numero);
//                 if (!valido)
//                 {
//                     Console.WriteLine("Insira um valor numérico válido!");
//                 }
//             } while (!valido);
//             return numero;
//         }
//     }
// }

// 26) Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente
// using System;
// namespace Exercicio26PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             for (int i = 100; i > 0; i--)
//             {
//                 Thread.Sleep(200);
//                 Console.WriteLine(i);
//             }
//             Thread.Sleep(200);
//             Console.Clear();
//         }
//     }
// }

// 27) Escreva um programa que leia:
// - a quantidade de números que deverá processar;
// - os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial.
// Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N 

//28)  Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.
// using System;
// namespace Exercicio28PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             for (int i = 100; i < 200; i++)
//             {
//                 if (i % 2 == 1)
//                 {
//                     Console.WriteLine(i);
//                 }
//             }
//         }
//     }
// }

// 29)  Faça um programa que exiba os números de 1 até 2000
// using System;
// namespace Exercicio29PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             for (int i = 0; i < 2000; i++)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }
// 30)  Faça um programa para imprimir uma tabuada. 
// using System;
// namespace Exercicio30PDF2
// {
//     public static class Program
//     {
//         public static void Main()
//         {
//             Console.WriteLine("Digite qual número deseja saber a tabuada");
//             int A = int.Parse(Console.ReadLine());
//             for (int i = 10; i > 0; i--)
//             {
                
//                 Console.WriteLine($" {i}*{A} = {i * A}");
//             }
//         }
//     }
// }

// 31)  Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba 
// ao  final  a  soma  total  dos  números  pares  lidos  e  também  a  soma  dos  números  ímpares  lidos.  Suporemos  que  o 
// número de elementos deste conjunto  não é conhecido, e que um número negativo será  utilizado para sinalizar  o 
// fim dos dados.
using System;
namespace Exercicio30PDF2
{
    public static class  Program
    {
        public static void Main()
        {
            
        }
    }
}
// 37) Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as
// seguintes opções:

// using System;
// namespace Exercicio37PDF2
// {
//     public static class Program
//     {
//         enum Menu { Somar= 1 , Subtrair, Dividir, Multiplicar, Sair }
//         public static void Main()
//         {   
//             bool escolheuSair = false;

//             while (!escolheuSair)
//             {
//                 Console.Clear();

//                 Console.WriteLine("[1] Somar \n[2] Subtrair\n[3] Dividir\n[4] Multiplicar\n[5] Sair");
//                 int opcInt = int.Parse(Console.ReadLine());
//                 Menu opcMenu = (Menu)opcInt;

//                 if (opcMenu != Menu.Sair)
//                 {
//                     (int A, int B) = obterValores();

//                     switch (opcMenu)
//                     {
//                         case Menu.Somar:
//                             Console.WriteLine($"Resultado da soma: {obterSoma(A, B)}");
//                             break;
//                         case Menu.Subtrair:
//                             Console.WriteLine($"Resultado da subtração: {obterSubtracao(A, B)}");
//                             break;
//                         case Menu.Dividir:
//                             Console.WriteLine($"Resultado da divisão: {obterDivisao(A, B)}");
//                             break;
//                         case Menu.Multiplicar:
//                             Console.WriteLine($"Resultado da multiplicação: {obterMultiplicacao(A, B)}");
//                             break;
//                         default:
//                             Console.WriteLine("Opção inválida.");
//                             break;
//                     }

//                     Console.WriteLine("\nPressione qualquer tecla para continuar...");
//                     Console.ReadKey();
//                 }
//                 else
//                 {
//                     escolheuSair = true;
//                     Console.WriteLine("Programa encerrado.");
//                     Thread.Sleep(2000);
//                 }
//             }
//         }
//     }
// }
//         private static (int, int) obterValores()
//         {
//             Console.WriteLine("\nDigite o valor do primeiro número:");
//             int A = int.Parse(Console.ReadLine());

//             Console.WriteLine("Digite o valor do segundo número:");
//             int B = int.Parse(Console.ReadLine());

//             return (A, B);
//         }

//         private static int obterSoma(int A, int B)
//         {
//             return A + B;
//         }

//         private static int obterSubtracao(int A, int B)
//         {
//             return A - B;
//         }

//         private static double obterDivisao(int A, int B)
//         {
//             if (B == 0)
//             {
//                 Console.WriteLine("Erro: Divisão por zero não é permitida.");
//                 return double.NaN;
//             }
//             return (double)A / B;
//         }
//         private static int obterMultiplicacao(int A, int B)
//         {
//             return A * B;
//         }
//     }
// }