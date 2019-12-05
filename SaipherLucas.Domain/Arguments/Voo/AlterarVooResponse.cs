using System;

namespace SaipherLucas.Domain.Arguments.Voo
{
    public class AlterarVooResponse
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }
        public string Message { get; set; }

        public static explicit operator AlterarVooResponse(Entities.Voo entidade)
        {
            return new AlterarVooResponse()
            {
                Id = entidade.Id,
                Numero = entidade.Numero,
                Data = entidade.Data,
                Horario = entidade.Horario,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
