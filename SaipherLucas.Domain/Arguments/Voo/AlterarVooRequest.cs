using System;

namespace SaipherLucas.Domain.Arguments.Voo
{
    public class AlterarVooRequest
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }
    }
}
