using SaipherLucas.Domain.Arguments.Base;
using SaipherLucas.Domain.Arguments.PlanoVoo;
using SaipherLucas.Domain.Interface.Services.Base;
using System;
using System.Collections.Generic;

namespace SaipherLucas.Domain.Interface.Services
{
    public interface IServicePlanoVoo : IBaseService
    {
        AdicionarPlanoVooResponse Adicionar(AdicionarPlanoVooRequest request);
        AlterarPlanoVooResponse Alterar(AlterarPlanoVooRequest request);
        IEnumerable<PlanoVooListResponse> Listar();
        BaseResponse Excluir(Guid id);
        PlanoVooResponse Consultar(Guid id);
    }
}
