using System;

namespace SaipherLucas.Domain.Arguments.PlanoVoo
{
    public class PlanoVooResponse
    {
        public Guid Id { get; set; }
        public Entities.Aeroporto AeroportoOrigem;
        public Entities.Aeroporto AeroportoDestino;
        public Entities.Voo Voo;
        public Entities.Aeronave Aeronave;
    }
}
