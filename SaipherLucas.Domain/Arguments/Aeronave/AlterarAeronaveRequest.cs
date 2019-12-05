using System;

namespace SaipherLucas.Domain.Arguments.Aeronave
{
    public class AlterarAeronaveRequest
    {
        public Guid Id { get; set; }
        public string Matricula { get; set; }
        public string Tipo { get; set; }
    }
}
