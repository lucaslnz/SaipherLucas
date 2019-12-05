using System;
using SaipherLucas.Domain.Entities;

namespace SaipherLucas.Domain.Arguments.Aeroporto
{
    public class AeroportoResponse
    {
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public static explicit operator AeroportoResponse(Entities.Aeroporto entidade)
        {
            return new AeroportoResponse()
            {
                Id = entidade.Id,
                Sigla = entidade.Sigla,
                Nome = entidade.Nome
            };
        }
    }
}
