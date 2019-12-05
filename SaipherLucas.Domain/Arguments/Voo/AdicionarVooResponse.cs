using System;

namespace SaipherLucas.Domain.Arguments.Voo
{
    public class AdicionarVooResponse
    {
        public Guid Id { get; set; }
        //public string Numero { get; set; }
        //public DateTime Data { get; set; }
        //public DateTime Horario { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarVooResponse(Entities.Voo entidade)
        {
            return new AdicionarVooResponse()
            {
                Id = entidade.Id,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
