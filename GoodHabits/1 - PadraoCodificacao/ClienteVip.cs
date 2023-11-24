/*
 * Padrão de Codificação: Definem um conjunto de regras e conveções para escrita de código, tornando-o mais legível, 
 * fácil de manter e menos propenso a erros. Esse padrão pode abranger disposição de espaçamentos, indentação e até 
 * como os comentários vão ser formatados.
 * 
 * Nomenclatura e Clareza: Refere-se diretamente à escolha de nomes descritivos para variáveis, funções e classes; 
 * algo que fere essa boa prática seria o uso de abreviações ou letras sem sentido.
 */

namespace GoodHabits.PadraoCodificacao
{
    internal class ClienteVip
    {
        public ClienteVip(
            Guid id, 
            DateTime dataCriacao, 
            string primeiroNome, 
            string sobrenome, 
            int idade, 
            DateTime dataNascimento, 
            string endereco)
        {
            Id = id;
            DataCriacao = dataCriacao;
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Idade = idade;
            DataNascimento  = dataNascimento;
            Endereco = endereco;
        }

        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public ClienteVip Criar(
            string primeiroNome,
            string sobrenome,
            int idade,
            DateTime dataNascimento,
            string endereco)
        {
            return new ClienteVip(Guid.NewGuid(), DateTime.Now, primeiroNome, sobrenome, idade, dataNascimento, endereco);
        }
    }
}
