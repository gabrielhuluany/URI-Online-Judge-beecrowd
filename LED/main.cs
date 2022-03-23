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
    
    Console.Write("Digite o número de casos de teste: ");
    int n = int.Parse(Console.ReadLine());
    
    int[] valores = new int[n];
    
    for(int i = 0; i < n; i++) {
    	Console.Write("Digite um número: ");
	string numero = Console.ReadLine();
	
	for(int j = 0; j < numero.Count(); j++) {
	    switch(numero[j]) {
	       case '0':
	       case '6':
	       case '9':
	           valores[i] += 6;
	           break;
	       case '1':
	           valores[i] += 2;
	           break;
	       case '2':
	       case '3':
	       case '5':
	           valores[i] += 5;
	           break;
	       case '4':
	           valores[i] += 4;
	           break;
	       case '7':
	           valores[i] += 3;
	           break;
	       case '8':
	           valores[i] += 7;
	           break;
	       default:
	           valores[i] += 0;
	           break;
	    }
	}
    }
    
    for(int k = 0; k < n; k++) {
       Console.WriteLine(valores[k] + " leds");
    }
  }
}
