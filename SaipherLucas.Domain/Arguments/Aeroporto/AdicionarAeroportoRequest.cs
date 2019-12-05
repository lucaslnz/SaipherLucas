using SaipherLucas.Domain.Interface.Arguments;

namespace SaipherLucas.Domain.Arguments.Aeroporto
{
    public class AdicionarAeroportoRequest : IRequest
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}
