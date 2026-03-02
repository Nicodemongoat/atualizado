using System;

namespace projetobanco
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public abstract void ExibirDocumento();
    }
}