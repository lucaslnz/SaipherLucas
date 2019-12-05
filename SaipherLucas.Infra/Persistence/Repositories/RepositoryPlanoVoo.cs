using System;
using SaipherLucas.Domain.Entities;
using SaipherLucas.Domain.Interface.Repositories;
using SaipherLucas.Infra.Persistence.Repositories.Base;

namespace SaipherLucas.Infra.Persistence.Repositories
{
    public class RepositoryPlanoVoo : BaseRepository<PlanoVoo, Guid>, IRepositoryPlanoVoo
    {
        protected readonly SaipherLucasContext _context;

        public RepositoryPlanoVoo(SaipherLucasContext context) : base(context)
        {
            _context = context;
        }
    }
}
