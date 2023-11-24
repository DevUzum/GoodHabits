namespace GoodHabits.Refatoracao
{
    public class Joquempo
    {
        public string JoquempoMethod(int player1, int player2)
        {
            //Pedra: 1
            if (player1 == 1 && player2 == 2)
            {
                return "Player 2 Venceu!";
            }
            else if (player1 == 1 && player2 == 3)
            {
                return "Player 1 Venceu!";
            }
            else if (player1 == 1 && player2 == 1)
            {
                return "Empate!";
            }

            //Papel: 2
            if (player1 == 2 && player2 == 1)
            {
                return "Player 1 Venceu!";
            }
            else if (player1 == 2 && player2 == 3)
            {
                return "Player 2 Venceu!";
            }
            else if (player1 == 2 && player2 == 2)
            {
                return "Empate!";
            }

            //Tesoura: 3
            if (player1 == 3 && player2 == 1)
            {
                return "Player 2 Venceu!";
            }
            else if (player1 == 3 && player2 == 2)
            {
                return "Player 1 Venceu!";
            }
            else if (player1 == 3 && player2 == 3)
            {
                return "Empate!";
            }

            return "Nenhuma opção encontrada";
        }
    }
}
