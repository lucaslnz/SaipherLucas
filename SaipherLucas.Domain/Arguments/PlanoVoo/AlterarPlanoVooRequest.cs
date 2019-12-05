using System;

namespace SaipherLucas.Domain.Arguments.PlanoVoo
{
    public class AlterarPlanoVooRequest
    {
        public Guid Id { get; set; }
        public Guid IdAeroportoOrigem { get; set; }
        public Guid IdAeroportoDestino { get; set; }
        public Guid IdAeronave { get; set; }
        public Guid IdVoo { get; set; }
    }
}
