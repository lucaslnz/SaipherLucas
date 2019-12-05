using System;

namespace SaipherLucas.Domain.Arguments.Voo
{
    public class AdicionarVooRequest
    {
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }
    }
}
