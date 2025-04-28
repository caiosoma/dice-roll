Console.WriteLine("Nome do Player 1: ");
Jogador player1 = new(Console.ReadLine());

Console.WriteLine("\nNome do Player 2: ");
Jogador player2 = new(Console.ReadLine());

Console.WriteLine($"\nJogador 1: { player1.Nome }\nJogador 2: { player2.Nome }\n"); // só pra testar

int totalPontosJ1 = 0;
int totalPontosJ2 = 0;

for (int i = 0; i < 3; i++)
{ 
    Console.WriteLine($"Pressione qualquer tecla para iniciar a rodada {i+1}.");
    Console.ReadLine();

    player1.JogarDados();
    player2.JogarDados();

    Console.WriteLine("Jogando...\n");
    Thread.Sleep(2000);

    Console.WriteLine($"{player1.Nome} tirou {player1.Numero} no dado.");
    Console.WriteLine($"{player2.Nome} tirou {player2.Numero} no dado.");

}

totalPontosJ1 += player1.Numero;
totalPontosJ2 += player2.Numero;

if (totalPontosJ1 > totalPontosJ2)
{
    Console.WriteLine($"{player1.Nome} ganhou!!");
}
else if (totalPontosJ2 > totalPontosJ1)
{
    Console.WriteLine($"{player2.Nome} ganhou!!");
}
else
{
    Console.WriteLine("Empate!");
}
