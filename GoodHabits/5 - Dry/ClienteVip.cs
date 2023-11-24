/*
 * DRY (Don't Repeat Yourself) - o princípio DRY (Don't Repeat Yourself) enfatiza a importância de não repetir código.
 * Ele sugere reutilizar e organizar o código para evitar duplicações, tornando-o mais fácil de manter, entender e modificar.
 */

namespace GoodHabits.Dry
{
    public class ClienteVip
    {
        public void MascararCpf(List<string> cpfs)
        {
            foreach (var cpf in cpfs)
            {
                if (cpf.Length == 11)
                {
                    // Mascara todos os dígitos, exceto os últimos três
                    string cpfMascarado1 = new string('*', cpf.Length - 3) + cpf.Substring(cpf.Length - 3);

                    Console.WriteLine("CPF mascarado: " + cpfMascarado1);
                }
                else
                {
                    Console.WriteLine("CPF inválido");
                }
            }
        }
    }
}
