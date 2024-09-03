/*-------------------------------------------------------------------
Questão 3: Loja de Poções
* Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
* Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
* Guerreiro recebe 10% de desconto na compra de poções de Vida.
* Mago recebe 15% de desconto na compra de poções de Mana.
* Paladino recebe 20% de desconto na compra de poções de Resistência.
* Exiba o preço total com e sem desconto.
@Lista: 02 - Condicionais
@Autor: Lucas Azevedo Sampaio
@Data: 23/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
            string? tpp, pocao;
            int quantidade, resultados;
            double totais;
            
        Console.WriteLine ("Informe a classe do seu personagem?");
        tpp = Console.ReadLine();
        
        Console.WriteLine ("Informe o tipo de porcao que você deseja comprar:");
        pocao = Console.ReadLine();
        
        
        Console.WriteLine ("Informe a quantidade de pocoes que voce deseja:");
        int.TryParse(Console.ReadLine(), out quantidade);
        
        if(pocao == "vida")
        {
            resultados = 10 * quantidade;
            Console.WriteLine($"Resultado sem desconto:{resultados}");
        }
        if(pocao == "mana")
        {
        resultados = 15 * quantidade;
        Console.WriteLine($"Resultado sem desconto:{resultados}");
        }
         if(pocao == "resistencia")
        {
        resultados = 20 * quantidade;
        Console.WriteLine($"Resultado sem desconto :{resultados}");
        }
        if(tpp == "guerreiro" && pocao == "vida")
        {
            resultados = (10 * quantidade);
            totais = resultados - (resultados * 0.1);
            Console.WriteLine($"O resultado sem desconto:{resultados}");
            Console.WriteLine($"Resultado com desconto:{totais}");
        }
        if(tpp == "mago" && pocao == "mana")
        {
            resultados = (15 * quantidade);
            totais = resultados - (resultados * 0.15);
             Console.WriteLine($"O resultado sem desconto:{resultados}");
            Console.WriteLine($"Resultado com descoonto:{totais}");
        }
        if(tpp == "paladino" && pocao== "resistencia")
        {
            resultados = (20 * quantidade);
           totais = resultados - (resultados * 0.2);
             Console.WriteLine($"O resultado sem desconto:{resultados}");
           Console.WriteLine($"Resultado com desconto:{totais}");
        }
     }
}