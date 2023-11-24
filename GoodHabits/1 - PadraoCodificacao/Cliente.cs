using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodHabits.PadraoCodificacao
{
    internal class Cliente
    {
        public Cliente(Guid id, DateTime dataCriadoEm, string nome1, string nome2, int age, DateTime dt_Nascimaneto, string endereço)
        {
            Identificador = id;

            DataCriadoEm = dataCriadoEm;

            Nome1 = nome1;

            Nome2 = nome2;

            Age = age;

            Dt_Nascimaneto = dt_Nascimaneto;

            Endereço = endereço;
        }

        public Guid Identificador { get; set; }

        public DateTime DataCriadoEm { get; set; }

        public string Nome1 { get; set; }

        public string Nome2 { get; set; }

        public int Age { get; set; }

        public DateTime Dt_Nascimaneto { get; set; }

        public string Endereço { get; set; }

        public Cliente Criar(string nome1, string nome2, int age, DateTime dt_Nascimaneto, string endereço)
        {
            return new Cliente(Guid.NewGuid(), DateTime.Now, nome1, nome2, age, dt_Nascimaneto, endereço);
        }
    }
}
