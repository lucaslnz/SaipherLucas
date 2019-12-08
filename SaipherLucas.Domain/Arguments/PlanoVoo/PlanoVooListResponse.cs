using System;
using SaipherLucas.Domain.Entities;

namespace SaipherLucas.Domain.Arguments.PlanoVoo
{
    public class PlanoVooListResponse
    {
        public Guid Id { get; set; }
        public string AeroportoOrigemNome { get; set; }
        public string AeroportoOrigemSigla { get; set; }
        public string AeroportoDestinoNome { get; set; }
        public string AeroportoDestinoSigla { get; set; }
        public string VooNumero { get; set; }
        public DateTime VooData { get; set; }
        public DateTime VooHorario { get; set; }
        public string AeronaveMatricula { get; set; }
        public string AeronaveTipo { get; set; }
    }
}
