using System;
using SaipherLucas.Domain.Entities;
using SaipherLucas.Domain.Interface.Repositories;
using SaipherLucas.Infra.Persistence.Repositories.Base;

namespace SaipherLucas.Infra.Persistence.Repositories
{
    public class RepositoryAeronave : BaseRepository<Aeronave, Guid>, IRepositoryAeronave
    {
        protected readonly SaipherLucasContext _context;

        public RepositoryAeronave(SaipherLucasContext context) : base(context)
        {
            _context = context;
        }
    }
}
