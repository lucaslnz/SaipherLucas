using System;

namespace SaipherLucas.Domain.Arguments.PlanoVoo
{
    public class PlanoVooResponse
    {
        public Guid Id { get; set; }
        public Entities.Aeroporto aeroportoOrigem;
        public Entities.Aeroporto aeroportoDestino;
        public Entities.Voo voo;
        public Entities.Aeronave aeronave;

        //public PlanoVooResponse(Guid id, Entities.Aeroporto aeroportoOrigem, Entities.Aeroporto aeroportoDestino, Entities.Voo voo, Entities.Aeronave aeronave)
        //{
        //    Id = id;
        //    this.aeroportoOrigem = aeroportoOrigem;
        //    this.aeroportoDestino = aeroportoDestino;
        //    this.voo = voo;
        //    this.aeronave = aeronave;
        //}
    }
}
