/*
https://www.beecrowd.com.br/judge/pt/problems/view/1168

beecrowd | 1168
LED
Autor Desconhecido

João quer montar um painel de leds contendo diversos números. 
Ele não possui muitos leds, e não tem certeza se conseguirá montar o número desejado. 
Considerando a configuração dos leds dos números abaixo, faça um algoritmo que ajude 
João a descobrir a quantidade de leds necessário para montar o valor.

	-–––––––––––––––––––––––––––––––––––––-
	|  _     _  _       _   _  _   _   _  |
	| | | |  _| _| |_| |_  |_   | |_| |_| |
	| |_| | |_  _|   |  _| |_|  | |_|  _| |
	|                                     |
	-–––––––––––––––––––––––––––––––––––––-

Entrada
A entrada contém um inteiro N, (1 ≤ N ≤ 1000) correspondente ao número de casos de teste, 
seguido de N linhas, cada linha contendo um número (1 ≤ V ≤ 10100) correspondente ao valor 
que João quer montar com os leds.

Saída
Para cada caso de teste, imprima uma linha contendo o número de leds que João precisa 
para montar o valor desejado, seguido da palavra "leds".

	    ------------------------------------------------
	    |  Exemplo de Entrada   |   Exemplo de Saída   |
	    |  3                    |                      |
	    |  115380               |   27 leds            |
	    |  2819311              |   29 leds            |
	    |  23456                |   25 leds            |
	    ------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(" _     _  _       _   _  _   _   _ ");
    Console.WriteLine("| | |  _| _| |_| |_  |_   | |_| |_|");
    Console.WriteLine("|_| | |_  _|   |  _| |_|  | |_|  _|");
    Console.WriteLine("\n");
    
    int[] LED = new int[10];
    LED[0] = 6;
    LED[1] = 2;
    LED[2] = 5;
    LED[3] = 5;
    LED[4] = 4;
    LED[5] = 5;
    LED[6] = 6;
    LED[7] = 3;
    LED[8] = 7;
    LED[9] = 6;
    
    Console.Write("Digite o número de casos de teste: ");
    int n = int.Parse(Console.ReadLine());
    
    Console.Write("Digite um número: ");
    List<int> lista = new List<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToList());
    
    Console.WriteLine("\nTeste");
    Console.WriteLine("{0}", string.Join(" ", lista));
  }
}
