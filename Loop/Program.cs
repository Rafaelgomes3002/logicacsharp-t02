//loop for

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

int soma = 0;
for (int i = 1; i <= 100; i++)
{
    soma += i; // soma o valor de i á variavel soma, exemplo: 1+2+3+4...+99+100
}

Console.WriteLine("A soma dos números de 1 a 100 é: " + soma);

//loop ifinito
/*
for (;;)
{
    Console.WriteLine("Este é um loop inifinito!");
}
*/

//Loop White (enquanto)
int contador = 1;

while (contador <= 5)
{
    Console.WriteLine(contador);
    contador++;  // Incrementa o contador 
}


//Loop do White (faça enquanto)
int novocontador = 2;

do
{
    Console.WriteLine(novocontador);
    novocontador++; //Incrementa o contador 
}  while (novocontador <= 5);


//Loop Infinito While
/*
while (true)
{
    Console.WriteLine("Este é um loop infinito!");
}
*/

//Uma lista de strings 
List<String> nomes = new List<String> { "Ana", "Carlos", "João", "Maria" };
//Usando o foreach para percorrer a lista
foreach (string nome in nomes)
{
    Console.WriteLine(nome); // Imprime cada nome exibindo na tela 
}

// Um vetor de números inteiros 
int[] numeros = { 1, 2, 3, 4, 5 };

// Usando o foreach para percorrer o vetor
foreach (int numero in numeros)
{
    Console.WriteLine(numero); //Imprimir cada número exibindo na tela
}

