using system;


namespace projetobanco
{
    public class TransacaoTed : Transacao
    {
        public string Finalidade { get; set; }

        public override bool Validar()
        {

            return _valor > 5000;
        }
    }
}