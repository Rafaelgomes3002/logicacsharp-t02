// Exercícios com array e foreach:


/* 1.Faça um programa de listas de peças de carro 
Crie um programa que tenha um array de nomes de 10 peças de carro e imprima 
todos os nomes em uma lista. */

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        Exercicio1_PecasCarro();
        Exercicio2_DadosGato();
        Exercicio3_ContinuarDigitando();
        Exercicio4_TabuadaDo3();


    }

    static void Exercicio1_PecasCarro()
    {
        string[] pecas = {"Motor", "Embreagem", "Radiador", "Pneu", "Freio",
            "Bateria", "Vela", "Filtro de ar", "Parachoque", "Suspensão"};

        Console.WriteLine("Lista de Peças de Carro:");
        foreach (string p in pecas)
        {
            Console.WriteLine(p);
        }
    }


    /*2. Faça um programa de desconto 
   Crie um programa que tenha um array associativo com dados de um gato que 
   chegou no petshop, como chave e seu valor. Utilize o foreach para imprimir os 
   nomes dos dados do gato. */
    static void Exercicio2_DadosGato()
    {
        Dictionary<string, string> gato = new Dictionary<string, string>()
        {
            { "Nome", "Mingau" },
            { "Idade", "2 anos" },
            { "Raça", "Siamês" },
            { "Peso", "4 kg" },
            { "Cor", "Branco" }
        };

        Console.WriteLine("Dados do gato no Petshop:");
        foreach (var dado in gato)
        {
            Console.WriteLine($"{dado.Key}: {dado.Value}");
        }
    }



    /* 1.Faça um programa que pergunte se a pessoa quer continuar 
    O programa pergunta se o usuário quer continuar digitando. 
    Enquanto ele responder “s”, o programa repete. */

    static void Exercicio3_ContinuarDigitando()
    {
        string opcao;

        do
        {
            Console.WriteLine("Você quer continuar digitando? (s/n)");
            opcao = Console.ReadLine();

        } while (opcao == "s");

        Console.WriteLine("Programa encerrado!");
    }


    /* 2. Faça um programa de tabuada do 3 
   Crie um programa em C# que mostre a tabuada do número 3 de 1 a 10. 
   Use a estrutura do...while e declare a variável do contador já na mesma linha em 
   que ela é criada. 
   O programa deve exibir o resultado da multiplicação a cada repetição. */

    static void Exercicio4_TabuadaDo3()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"3 x {i} = {3 * i}");
        }
    }
}