using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        // Adicionando elementos
        nomes.Add("Ana");
        nomes.Add("Bruno");
        nomes.Add("Carlos");

        Console.WriteLine(nomes[0]);  //Ana
        Console.WriteLine(nomes[1]);  //Bruno
        Console.WriteLine(nomes[2]);  // Carlos

        Console.WriteLine("Lista após adicionar elementos:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nomes);
        }

        // Adicionar novo nome
        nomes.Add("Daniel");
        Console.WriteLine("\nLista após adicionar 'Daniel' :");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nomes);
        }

        // Removendo elementos
        nomes.Remove("Bruno"); //remove pelo valor 

        Console.WriteLine("\nLista após remover 'Bruno' :");
        foreach(string nome in nomes)
        {
            Console.WriteLine(nomes);
        }
        
        // Removendo pelo Indice
        nomes.RemoveAt(0);  // remove o primeiro (Ana)

        Console.WriteLine("\nLista após remover o indice 0 (Ana):");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nomes);
        }
        
        // Limpando toda a lista 
        nomes.Clear();

        Console.WriteLine("\nLista após Clear():");
        Console.WriteLine("Qualidade de elementos: " + nomes.Count);
    }



}