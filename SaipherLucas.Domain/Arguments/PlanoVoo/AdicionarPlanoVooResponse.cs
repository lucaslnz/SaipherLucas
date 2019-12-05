using System;
using SaipherLucas.Domain.Entities;

namespace SaipherLucas.Domain.Arguments.PlanoVoo
{
    public class AdicionarPlanoVooResponse
    {
        public Guid Id { get; set; }
        public Guid IdAeroportoOrigem { get; set; }
        public Guid IdAeroportoDestino { get; set; }
        public Guid IdAeronave { get; set; }
        public Guid IdVoo { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarPlanoVooResponse(Entities.PlanoVoo entidade)
        {
            return new AdicionarPlanoVooResponse()
            {
                Id = entidade.Id,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
