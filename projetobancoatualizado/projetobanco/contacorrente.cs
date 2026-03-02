using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projetobanco
{
    public class ContaCorrente : ContaBancaria
    {
        public override void CalcularTarifa()
        {
            Saldo -= 15.00m;
        }
    }
}
