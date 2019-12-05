using System;

namespace SaipherLucas.Domain.Arguments.Aeroporto
{
    public class AlterarAeroportoRequest
    {
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}
