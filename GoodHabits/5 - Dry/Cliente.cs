namespace GoodHabits.Dry
{
    public class Cliente
    {
        public void MascararCpf(List<string> cpf)
        {
            if (cpf[0].Length == 11)
            {
                // Mascara todos os dígitos, exceto os últimos três
                string cpfMascarado1 = new string('*', cpf[0].Length - 3) + cpf[0].Substring(cpf[0].Length - 3);

                Console.WriteLine("CPF mascarado: " + cpfMascarado1);
            }
            else
            {
                Console.WriteLine("CPF inválido");
            }

            if (cpf[1].Length == 11)
            {
                // Mascara todos os dígitos, exceto os últimos três
                string cpfMascarado1 = new string('*', cpf[1].Length - 3) + cpf[1].Substring(cpf[1].Length - 3);

                Console.WriteLine("CPF mascarado: " + cpfMascarado1);
            }
            else
            {
                Console.WriteLine("CPF inválido");
            }
        }
    }
}
