/*
 * Padrão de Codificação: Definem um conjunto de regras e conveções para escrita de código, tornando-o mais legível, fácil de manter e menos propenso a erros.
 * 
 * Bom: Usar nomes descritivos e significativos.
 * Ruim: Usar abreviações ou nomes de variáveis sem sentido.
 */

namespace GoodHabits.PadraoCodificacao
{
    internal class ClienteVip
    {
        public ClienteVip(
            Guid id, 
            DateTime dataCriacao, 
            string nome, 
            string sobrenome, 
            int idade, 
            DateTime dataNascimento, 
            string endereco)
        {
            Id = id;
            DataCriacao = dataCriacao;
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            DataNascimento  = dataNascimento;
            Endereco = endereco;
        }

        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public ClienteVip Criar(
            string nome,
            string sobrenome,
            int idade,
            DateTime dataNascimento,
            string endereco)
        {
            return new ClienteVip(Guid.NewGuid(), DateTime.Now, nome, sobrenome, idade, dataNascimento, endereco);
        }
    }
}
