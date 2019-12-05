using System;

namespace SaipherLucas.Domain.Arguments.PlanoVoo
{
    public class AlterarPlanoVooResponse
    {
        public Guid Id { get; set; }
        public Guid IdAeroportoOrigem { get; set; }
        public Guid IdAeroportoDestino { get; set; }
        public Guid IdAeronave { get; set; }
        public Guid IdVoo { get; set; }
        public string Message { get; set; }

        public static explicit operator AlterarPlanoVooResponse(Entities.PlanoVoo entidade)
        {
            return new AlterarPlanoVooResponse()
            {
                Id = entidade.Id,
                IdAeroportoOrigem = entidade.IdAeroportoOrigem,
                IdAeroportoDestino = entidade.IdAeroportoDestino,
                IdAeronave = entidade.IdAeronave,
                IdVoo = entidade.IdVoo,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
