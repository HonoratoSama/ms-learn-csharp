/*
definições das notas em Letras
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
*/
// Bloco de criação e inicialização das Matrizes
using System.Linq.Expressions;

int[] notasClaudio = [ 85, 90, 70, 80, 90];
int[] notasMarcio  = [ 65, 70, 30, 95, 90];
int[] notasAna     = [100, 80, 90, 90, 90];
int[] notasMaria   = [ 15, 20, 20, 10, 50];

// Bloco de criação e inicialização das variaveis de total de notas
int totalClaudio = 0;
int totalMarcio  = 0;
int totalAna     = 0;
int totalMaria   = 0;

// Bloco de criação e inicialiação das variáveis de média dos alunos
int mediaClaudio = 0;
int mediaMarcio = 0;
int mediaAna = 0;
int mediaMaria = 0;

string nome = "";

//Bloco do total de notas de cada aluno
foreach (int nota in notasClaudio)
{
    totalClaudio += nota;
}
foreach (int nota in notasMarcio)
{
    totalMarcio += nota;
}
foreach (int nota in notasAna)
{
    totalAna += nota;
}
foreach (int nota in notasMaria)
{
    totalMaria += nota;
}

// Bloco de calculo da média
mediaClaudio = (totalClaudio / 5);
mediaMarcio = (totalMarcio / 5);
mediaAna = (totalAna / 5);
mediaMaria = (totalMaria / 5);

// Bloco da impressao do cabeçalho
Console.WriteLine("Aluno\t\tMédia");
nome = "Claudio";
// Bloco dos IFs para definição das notas em Letras
if(mediaClaudio < 60)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tF");
}
else if( mediaClaudio < 63)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tD-");
}
else if (mediaClaudio < 67)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tD");
}
else if (mediaClaudio < 70)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tD+");
}
else if (mediaClaudio < 73)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tC-");
}
else if (mediaClaudio < 77)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tC");
}
else if (mediaClaudio < 80)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tC+");
}
else if (mediaClaudio < 83)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tB-");
}
else if (mediaClaudio < 87)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tB");
}
else if (mediaClaudio < 90)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tB+");
}
else if (mediaClaudio < 93)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tA-");
}
else if (mediaClaudio < 97)
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tA");
}
else
{
    Console.WriteLine($"{nome}\t\t{mediaClaudio}\tA+");
}
// Marcio
nome = "Marcio";
if (mediaMarcio < 60)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tF");
}
else if (mediaMarcio < 63)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tD-");
}
else if (mediaMarcio < 67)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tD");
}
else if (mediaMarcio < 70)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tD+");
}
else if (mediaMarcio < 73)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tC-");
}
else if (mediaMarcio < 77)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tC");
}
else if (mediaMarcio < 80)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tC+");
}
else if (mediaMarcio < 83)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tB-");
}
else if (mediaMarcio < 87)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tB");
}
else if (mediaMarcio < 90)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tB+");
}
else if (mediaMarcio < 93)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tA-");
}
else if (mediaMarcio < 97)
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tA");
}
else
{
    Console.WriteLine($"{nome}\t\t{mediaMarcio}\tA+");
}
// Ana
nome = "Ana";
if (mediaAna < 60)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tF");
}
else if (mediaAna < 63)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tD-");
}
else if (mediaAna < 67)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tD");
}
else if (mediaAna < 70)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tD+");
}
else if (mediaAna < 73)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tC-");
}
else if (mediaAna < 77)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tC");
}
else if (mediaAna < 80)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tC+");
}
else if (mediaAna < 83)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tB-");
}
else if (mediaAna < 87)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tB");
}
else if (mediaAna < 90)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tB+");
}
else if (mediaAna < 93)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tA-");
}
else if (mediaAna < 97)
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tA");
}
else
{
    Console.WriteLine($"{nome}\t\t{mediaAna}\tA+");
}
// Maria
nome = "Maria";
if (mediaMaria < 60)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tF");
}
else if (mediaMaria < 63)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tD-");
}
else if (mediaMaria < 67)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tD");
}
else if (mediaMaria < 70)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tD+");
}
else if (mediaMaria < 73)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tC-");
}
else if (mediaMaria < 77)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tC");
}
else if (mediaMaria < 80)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tC+");
}
else if (mediaMaria < 83)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tB-");
}
else if (mediaMaria < 87)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tB");
}
else if (mediaMaria < 90)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tB+");
}
else if (mediaMaria < 93)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tA-");
}
else if (mediaMaria < 97)
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tA");
}
else
{
    Console.WriteLine($"{nome}\t\t{mediaMaria}\tA+");
}