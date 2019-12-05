using SaipherLucas.Domain.Arguments.Aeronave;
using SaipherLucas.Domain.Arguments.Base;
using SaipherLucas.Domain.Interface.Services.Base;
using System;
using System.Collections.Generic;

namespace SaipherLucas.Domain.Interface.Services
{
    public interface IServiceAeronave : IBaseService
    {
        AdicionarAeronaveResponse Adicionar(AdicionarAeronaveRequest request);
        AlterarAeronaveResponse Alterar(AlterarAeronaveRequest request);
        IEnumerable<AeronaveResponse> Listar();
        BaseResponse Excluir(Guid id);
    }
}
