using System;
using SaipherLucas.Domain.Entities;
using SaipherLucas.Domain.Interface.Repositories;
using SaipherLucas.Infra.Persistence.Repositories.Base;

namespace SaipherLucas.Infra.Persistence.Repositories
{
    public class RepositoryVoo : BaseRepository<Voo, Guid>, IRepositoryVoo
    {
        protected readonly SaipherLucasContext _context;

        public RepositoryVoo(SaipherLucasContext context) : base(context)
        {
            _context = context;
        }
    }
}
