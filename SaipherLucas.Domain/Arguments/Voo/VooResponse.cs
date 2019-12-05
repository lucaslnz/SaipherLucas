using System;
using SaipherLucas.Domain.Entities;

namespace SaipherLucas.Domain.Arguments.Voo
{
    public class VooResponse
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }

        public static explicit operator VooResponse(Entities.Voo entidade)
        {
            return new VooResponse()
            {
                Id = entidade.Id,
                Numero = entidade.Numero,
                Data = entidade.Data,
                Horario = entidade.Horario
            };
        }
    }
}
