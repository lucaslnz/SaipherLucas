using System;
using SaipherLucas.Domain.Entities;
using SaipherLucas.Domain.Interface.Repositories;
using SaipherLucas.Infra.Persistence.Repositories.Base;

namespace SaipherLucas.Infra.Persistence.Repositories
{
    public class RepositoryAeroporto : BaseRepository<Aeroporto, Guid>, IRepositoryAeroporto
    {
        protected readonly SaipherLucasContext _context;

        public RepositoryAeroporto(SaipherLucasContext context) : base(context)
        {
            _context = context;
        }
    }
}
