/*1.Saudação com Nome
Objetivo: Declarar variáveis, usar concatenação e interpolação.
Descrição: Crie um script que declare uma variável para o nome de 
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá, 
João! Bem - vindo ao nosso site!".
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de 
uma string com aspas duplas.*/

string nome = "Maria";

Console.WriteLine($"Olá, {nome} Bem - vindo ao nosso site!"); // interpolação
Console.WriteLine("Olá " +  nome  + " Bem - vindo ao nosso site!"); //concatenação

/*2.Conversão de Temperatura(Celsius para Fahrenheit)
Objetivo: Trabalhar com cálculos matemáticos e variáveis.
Descrição: Crie um script que converta uma temperatura em Celsius 
para Fahrenheit. A fórmula para conversão é: 
Dica: Declare uma constante para armazenar o valor 9/5 e faça o 
cálculo com a variável fornecida.*/

const double divisao = 9.0/5.0;
double c = 32;
double f = (c * divisao) + 32;
Console.WriteLine($"{c} graus, é igual a {f} Fahrenheit");

/*3.Impressão de Dados do Usuário
Objetivo: Concatenar e interpolar dados.
Descrição: Crie um script que solicite ao usuário seu nome, idade e 
cidade e depois mostre uma mensagem com essas informações. 
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo".
Dica: Use tanto concatenação quanto interpolação.*/
string nomeUsuario = "Rafael";
int idade = 26;
string cidade = "São Paulo";
Console.WriteLine($"Meu nome é {nomeUsuario}, tenho {idade} anos e moro em {cidade}"); // interpolação
Console.WriteLine($"Meu nome é " + nomeUsuario + " tenho " + idade + " anos e moro em " + cidade); //concatenação

/*4. Empréstimo Bancário
Objetivo: Cálculos financeiros e declaração de variáveis.
Descrição: Crie um script que calcule o valor de uma parcela de um 
empréstimo, dado o valor total do empréstimo, a taxa de juros e o 
número de parcelas. Exemplo de fórmula: 
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o 
número de parcelas.*/
double valorEmprestimo = 2000.0;
double taxaJuros = 0.05;
int numeroParcelas = 12;

double parcela = (valorEmprestimo * (1 + taxaJuros)) / numeroParcelas;
Console.WriteLine($"Valor da parcela: R$ {parcela:F2}");

/*5. Conversor de Moeda
Objetivo: Trabalhar com variáveis, operadores e arredondamento.
Descrição: Crie um script que converta uma quantia em reais para 
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor 
convertido com 2 casas decimais.
Dica: Use round() para arredondar o valor para 2 casas decimais.*/
double reais = 150.00;
double taxaCambio = 5.33;

double dolares = reais / taxaCambio;
dolares = Math.Round(dolares, 2);

Console.WriteLine($"R$ {reais} equivalem a US$ {dolares}");

/*6 . Calculadora de Desconto
Objetivo: Cálculos matemáticos e uso de variáveis.
Descrição: Crie um script que calcule o valor do desconto de um 
produto, dado o preço original e a porcentagem de desconto. Exemplo 
de fórmula: 
Dica: Use variáveis para armazenar o preço e a porcentagem do 
desconto e calcule o valor final.*/

double precoOriginal = 300.00;
double porcentagemDesconto = 10; // 10%

double valorDesconto = precoOriginal * (porcentagemDesconto / 100);
double precoFinal = precoOriginal - valorDesconto;

Console.WriteLine($"Preço final: R$ {precoFinal:F2}");
