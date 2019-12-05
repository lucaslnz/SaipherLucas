using System;
using SaipherLucas.Domain.Entities;

namespace SaipherLucas.Domain.Arguments.Aeronave
{
    public class AdicionarAeronaveResponse
    {
        public Guid Id { get; set; }
        //public string Matricula { get; set; }
        //public string Tipo { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarAeronaveResponse(Entities.Aeronave entidade)
        {
            return new AdicionarAeronaveResponse()
            {
                Id = entidade.Id,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
