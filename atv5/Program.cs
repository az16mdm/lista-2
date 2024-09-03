/*-------------------------------------------------------------------
Questão 5: Resgate no Labirinto
* Contextualização: Em uma missão de resgate em um jogo, o jogador deve decidir se continua
em frente para resgatar um aliado ou recua, considerando a vida restante, o número de
armadilhas conhecidas no caminho e a distância do aliado.
* Comando: Crie um programa que receba a porcentagem de vida do jogador, o número de
armadilhas conhecidas no caminho e a distância do aliado em metros. O programa deve decidir
se o jogador deve seguir em frente, tentar um resgate rápido, ou recuar, conforme as seguintes
condições:
* Se a vida for maior que 50% e as armadilhas forem menores que 3, seguir em frente.
* Se a vida for menor que 50%, as armadilhas forem menores que 2, e a distância do aliado for
menor que 10m, tentar resgate rápido.
* Caso contrário, recuar.


@Lista: 02 - Condicionais
@Autor: Lucas Azevedo Sampaio
@Data: 23/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{       
    public static void Main(string[] args)
    {
            int vida, a, distancia;
           Console.WriteLine("qual a sua porcentagem vida");
           int.TryParse(Console.ReadLine(), out vida);
            Console.WriteLine("qual o numero de armadilhas conhecidas no caminho");
            int.TryParse(Console.ReadLine(), out a);
           Console.WriteLine("qual a distancia dos aliados em metros.");
           int.TryParse(Console.ReadLine(), out distancia);
          if(vida > 50 && a < 3)
           {
               Console.WriteLine("Seguir em frente");
              
           }
         else if(vida < 50 && a < 2 && distancia < 10)
           {
               Console.WriteLine("Tentar resgate rapido");
          }
         else
         {
              Console.WriteLine("recuar");
          }
}
}

