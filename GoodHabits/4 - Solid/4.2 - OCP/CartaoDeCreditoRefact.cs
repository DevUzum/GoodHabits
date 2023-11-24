/*
 * Open Close Principle - Esse princípio prega que a classe está aberta para extensão e fechada para modificação; para 
 * que não seja ferido, deve ser evitado ao máximo mexer no que já existe e funciona diretamente, sendo a melhor alternativa
 * extender da classe e sobreescrever o que for necessário.
 */

namespace GoodHabits.Solid.OCP
{
    public abstract class CartaoDeCreditoRefact
    {
        public abstract decimal GerarDesconto(decimal custoMensal);
    }

    public class CartaoVisa : CartaoDeCreditoRefact
    {
        public override decimal GerarDesconto(decimal custoMensal)
        {
            return custoMensal * 0.02M;
        }
    }

    public class CartaoMasterCard : CartaoDeCreditoRefact
    {
        public override decimal GerarDesconto(decimal custoMensal)
        {
            return custoMensal * 0.05M;
        }
    }
}
