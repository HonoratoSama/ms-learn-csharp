// See https://aka.ms/new-console-template for more information
/* Exercício 1
Random dice1 = new Random();
Random dice2 = new Random();

Console.WriteLine($"A jogada é : {dice1.Next(1, 7)} {dice2.Next(1, 7)}");
*/
/* Exercício 2
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
*/

/* Exercício 3
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine($"O maior valor entre {firstValue} e {secondValue} é --> {largerValue}");
*/

/* Exercício 4 - Criar um jogo de dados (3 dados) -- Abaixo a minha solução
   caso dois dados apresentem o mesmo valor +2 pontos de bônus
   caso tres dados apresentem o mesmo valor +6 pontos de bônus
   caso a soma dos tres dados mais os bônus for igual ou superior a 15,
   você vencerá o jogo
   Premiação acrescentada ao decorrer do exercício:
   pontuação maior ou igual a 16 carro novo
   pontiação maior ou igual a 10 laptop novo
   pontuação exatamente 7, o premio será uma viagem
   caso contrario vira pai de Pet

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int pontos = 0;

Console.WriteLine($"Dado1: {roll1} Dado2: {roll2} Dado3: {roll3}");

if ((roll1 == roll2) && (roll1 == roll3))
{
    pontos = roll1 + roll2 + roll3 + 6;
    Console.WriteLine($"Parabéns !!! você ganhou 6 pontos de Bônus !!!");

}
else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    pontos = roll1 + roll2 + roll3 + 2;
    Console.WriteLine($"Parabéns !!! você ganhou 2 pontos de Bônus !!!");
}
else
{
    pontos = roll1 + roll2 + roll3;
}

if (pontos >= 15)
{
    Console.WriteLine($"Voçê venceu com {pontos} pontos, verifique sua premiação !!");
}
else
{
    Console.WriteLine($"Voçê fez apenas {pontos} pontos, verifique premiação !!");
}

if(pontos >= 16)
{
    Console.WriteLine($"Parabáns você ganhou um Carro Novinho !!");
}
else if(pontos >= 10)
{
    Console.WriteLine($"Parabáns você ganhou um Laptop Novinho !!");
}
else if(pontos == 7)
{
    Console.WriteLine($"Parabáns você ganhou uma Viagem com acompanhante !!");
}
else
{
    Console.WriteLine($"Se Fodeu, virou pai de Pet !!");
}
*/


// aqui a solução sugerida
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}
*/

// ###  D E S A F I O  ###

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


Console.WriteLine(daysUntilExpiration);

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Sua inscrição expirou !!");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Sua inscrição expira em um dia !");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Sua inscrição expira em {daysUntilExpiration} dias.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Sua inscrição expirará em breve. Renove Agora !!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renove agora e ganhe {discountPercentage}% de desconto");
}