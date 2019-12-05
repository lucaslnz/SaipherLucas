using System;

namespace SaipherLucas.Domain.Arguments.PlanoVoo
{
    public class AdicionarPlanoVooRequest
    {
        public Guid IdAeroportoOrigem { get; set; }
        public Guid IdAeroportoDestino { get; set; }
        public Guid IdAeronave { get; set; }
        public Guid IdVoo { get; set; }
    }
}
