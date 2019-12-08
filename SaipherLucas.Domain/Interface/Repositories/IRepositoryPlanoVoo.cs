using SaipherLucas.Domain.Arguments.PlanoVoo;
using SaipherLucas.Domain.Entities;
using SaipherLucas.Domain.Interface.Repositories.Base;
using System;
using System.Linq;

namespace SaipherLucas.Domain.Interface.Repositories
{
    public interface IRepositoryPlanoVoo : IBaseRepository<PlanoVoo, Guid>
    {
        IQueryable<PlanoVooListResponse> ListarPlanos();

        IQueryable<PlanoVooResponse> Consultar(Guid id);
    }
}
