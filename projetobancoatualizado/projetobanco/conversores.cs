using System;

namespace projetobanco{
    public class conversorbilhoes:IConversorGrandeza
    {
        public decimal converter(decimal valor) => valor / 1000000000m;
    }
    public class conversortrilhoes : IConversorGrandeza
    {
        public decimal converter(decimal valor) => valor / 1000000000000m;
    }
}
