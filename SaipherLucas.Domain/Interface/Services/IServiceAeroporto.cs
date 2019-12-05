using SaipherLucas.Domain.Arguments.Aeroporto;
using SaipherLucas.Domain.Arguments.Base;
using SaipherLucas.Domain.Interface.Services.Base;
using System;
using System.Collections.Generic;

namespace SaipherLucas.Domain.Interface.Services
{
    public interface IServiceAeroporto : IBaseService
    {
        AdicionarAeroportoResponse Adicionar(AdicionarAeroportoRequest request);
        AlterarAeroportoResponse Alterar(AlterarAeroportoRequest request);
        IEnumerable<AeroportoResponse> Listar();
        BaseResponse Excluir(Guid id);
    }
}
