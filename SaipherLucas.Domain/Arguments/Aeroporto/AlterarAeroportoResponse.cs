using System;

namespace SaipherLucas.Domain.Arguments.Aeroporto
{
    public class AlterarAeroportoResponse
    {
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public string Message { get; set; }

        public static explicit operator AlterarAeroportoResponse(Entities.Aeroporto entidade)
        {
            return new AlterarAeroportoResponse()
            {
                Id = entidade.Id,
                Sigla = entidade.Sigla,
                Nome = entidade.Nome,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
