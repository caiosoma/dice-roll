using System.Runtime.CompilerServices;

class Jogador
{
    public Jogador(string nome)
    {
        Nome = nome;
    } // construtor

    public string Nome { get; set; }
    public int Numero { get; set; }

    public void JogarDados()
    {
        Random random = new Random();
        Numero = random.Next(1, 5);
    } // método para jogar os dados usando a classe Random
};