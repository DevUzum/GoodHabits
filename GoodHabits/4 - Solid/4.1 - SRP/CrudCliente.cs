/*
 * Single Responsibility Principle - Esse princípio prega que não se pode ter uma classe deus que tenha todos os 
 * métodos; sendo assim para que não seja ferido, cada classe tem que ter sua responsabilidade.
 */

namespace GoodHabits.Solid.SRP
{
    //Errado
    internal class CrudCliente
    {
        public void CadastrarCliente()
        {
            //Regra de negócio
        }

        public void ExcluirCliente()
        {
            //Regra de negócio
        }

        public void EnviarEmail()
        {
            //Regra de negócio
        }
    }

    /*******************************************************************/

    //Certo
    internal class CrudClienteRefact
    {
        public void CadastrarCliente()
        {
            //Regra de negócio
        }

        public void ExcluirCliente()
        {
            //Regra de negócio
        }
    }

    internal class Notificacao
    {
        public void EnviarEmail()
        {
            //Regra de negócio
        }

        public void EnviarSms()
        {
            //Regra de negócio
        }
    }
}
