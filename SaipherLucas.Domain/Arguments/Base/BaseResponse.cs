namespace SaipherLucas.Domain.Arguments.Base
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }
        public string Message { get; set; }
    }
}
