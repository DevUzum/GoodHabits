namespace GoodHabits.Refatoracao
{
    public class JoquempoRefact
    {
        public string JoquempoMethod(Escolha player1, Escolha player2)
        {
            if (player1 == player2)
                return "Empate!";

            if (player1 == Escolha.Pedra && player2 == Escolha.Tesoura ||
                player1 == Escolha.Papel && player2 == Escolha.Pedra ||
                player1 == Escolha.Tesoura && player2 == Escolha.Papel)
            {
                return "Player 1 Venceu!";
            }
            else
            {
                return "Player 2 Venceu!";
            }
        }
    }

    public enum Escolha
    {
        Pedra = 1,
        Papel = 2,
        Tesoura = 3
    }
}
