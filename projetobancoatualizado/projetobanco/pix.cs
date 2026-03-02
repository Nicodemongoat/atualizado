using System;

namespace projetobanco
{
    public class TransacaoPix : Transacao
    {
        public string ChavePix { get; set; }

        public override bool Validar()
        {
            return _valor > 0 && _valor <= 10000;
        }
    }
}