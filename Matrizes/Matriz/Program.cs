/*
Bloco de comentarios de testes para inclusão da linha em
branco em C#
*/
//----------

/*
// declarando uma Matriz - exercício 1
using System.Runtime.Versioning;

string[] fraudulentOrderIDs = new string[3];

// atribuindo valores a uma Matriz
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";


// aqui a matriz é declarada e inicializada
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// mostrando os valores contidos numa matriz
Console.WriteLine($"Primeiro valor da Matriz: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Segundo  valor da Matriz: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Terceiro valor da Matriz: {fraudulentOrderIDs[2]}");

// reatribuindo valor a um indice específico da matriz
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"\nPrimeiro valor da Matriz: {fraudulentOrderIDs[0]}");

Console.WriteLine($"\nHá um total de {fraudulentOrderIDs.Length} Processos Fraudulentos !");
*/
/*
// utilizazndo foreach com Matriz - exercício 2
string[] nomes = ["Rowena", "Robin", "Bao"];

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}


// criando e inicializando uma matris de int - exercício 3
int[] inventario = { 200, 450, 700, 175, 250 };
int soma = 0;
int bin  = 0;
foreach (int itens in inventario)
{
    soma += itens;
    bin ++;
    Console.WriteLine($"Bin {bin} = {itens} items (Running total: {soma})");
}
Console.WriteLine($"Temos um total de {soma} no inventário");
*/
/*
// Exercício final - Minha solução
string[] possivelFraude = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
int total = 0;
int totalFraude = 0;

foreach (string fraude in possivelFraude)
{
    total++;
    if (fraude.StartsWith("B"))
    {
        totalFraude++;
        Console.WriteLine($"Necessária atenção no ID: {fraude}");
    }

}

Console.WriteLine($"Total de IDs Encontrados: {total}. Total de possíveis fraudes encontradas: {totalFraude} ");
*/
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");