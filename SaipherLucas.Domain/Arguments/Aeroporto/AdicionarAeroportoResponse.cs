using SaipherLucas.Domain.Interface.Arguments;
using System;

namespace SaipherLucas.Domain.Arguments.Aeroporto
{
    public class AdicionarAeroportoResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarAeroportoResponse(Entities.Aeroporto entidade)
        {
            return new AdicionarAeroportoResponse()
            {
                Id = entidade.Id,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
