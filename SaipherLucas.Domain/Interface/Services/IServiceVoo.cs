using SaipherLucas.Domain.Arguments.Base;
using SaipherLucas.Domain.Arguments.Voo;
using SaipherLucas.Domain.Interface.Services.Base;
using System;
using System.Collections.Generic;

namespace SaipherLucas.Domain.Interface.Services
{
    public interface IServiceVoo : IBaseService
    {
        AdicionarVooResponse Adicionar(AdicionarVooRequest request);
        AlterarVooResponse Alterar(AlterarVooRequest request);
        IEnumerable<VooResponse> Listar();
        BaseResponse Excluir(Guid id);
    }
}
