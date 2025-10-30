//variaveis
char letra = 'A';
string nome = "João";
float temperatura = 36.5f;
double salario = 12345.67;
bool estaChovendo = true;

//Alterando as variáveis 
letra = 'B';
nome = "Maria";
temperatura = 37.0f;
salario = 15000.50;
estaChovendo = false;

//Concatenação
const char simbolo = '$';
const string saudacao = "Bem-vindo ao C#!";
const float pi = 3.14159f;
const double altura = 1.75;
const bool ehVerdade = false;
const int numero = 14;




//Exbindo os valores originais 
Console.WriteLine("valores originais");
Console.WriteLine($"Letra: {letra}");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Temperatura: {temperatura}");
Console.WriteLine($"Salário: {salario}");
Console.WriteLine($"Está Chovendo? {estaChovendo}");



//Exbindo os valores originais por concatenação
Console.WriteLine("\nConstantes:");
Console.WriteLine("Simbolo:" + simbolo);
Console.WriteLine("Saudação: " +  saudacao);
Console.WriteLine("Valor de pi: " +  pi);
Console.WriteLine("Altura: " +  altura);
Console.WriteLine("É verdade? " +  ehVerdade);
Console.WriteLine("Número: " +  numero);

