namespace GoodHabits.Solid.OCP
{
    internal class CartaoDeCredito
    {
        public decimal GerarDesconto(int tipoCartao, decimal custoMensal)
        {
            if (tipoCartao == 0)
            {
                return custoMensal * 0.02M;
            }
            else 
            {
                return custoMensal * 0.05M;
            }
        }
    }
}
