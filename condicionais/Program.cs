//Condicional IF
using System.ComponentModel.Design;

string nome = "Ana";

if (nome == "Ana");
{
    Console.WriteLine("Olá, Ana!");
}

string texto = "";

if (string.IsNullOrEmpty(texto))
{
    Console.WriteLine("A string está vazia.");
}

//Condicional IF/ELSE
int idade = 16;
if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}


int numero = 7;

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é impar.");
}

//Condicional usando else if 
double nota = 6.5;

if (nota >= 9.0)
{
    Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
}
else if (nota >= 7.0)
{
    Console.WriteLine("Você está aprovado.");
}
else if (nota >= 5.0)
{
    Console.WriteLine("Você está em recuperação.");
}
else if (nota >= 3.0)
{
    Console.WriteLine("Você está com risco de reprovação.");
}
else
{
    Console.WriteLine("Você foi reprovação.");
}

