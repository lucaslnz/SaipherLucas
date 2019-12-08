using System;
using System.Linq;
using SaipherLucas.Domain.Arguments.PlanoVoo;
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

        public IQueryable<PlanoVooResponse> Consultar(Guid id)
        {
            IQueryable<PlanoVooResponse> query = (from a in _context.PlanosVoo
                                                where a.Id == id
                                                join b in _context.Aeroportos on a.IdAeroportoOrigem equals b.Id
                                                join c in _context.Aeroportos on a.IdAeroportoDestino equals c.Id
                                                join d in _context.Voos on a.IdVoo equals d.Id
                                                join e in _context.Aeronaves on a.IdAeronave equals e.Id

                                                select new PlanoVooResponse
                                                {
                                                    Id = a.Id,
                                                    aeroportoOrigem = b,
                                                    aeroportoDestino = c,
                                                    voo = d,
                                                    aeronave = e
                                                });
            return query;
        }

        public IQueryable<PlanoVooListResponse> ListarPlanos()
        {
            IQueryable<PlanoVooListResponse> query = (from a in _context.PlanosVoo
                            join b in _context.Aeroportos on a.IdAeroportoOrigem equals b.Id
                            join c in _context.Aeroportos on a.IdAeroportoDestino equals c.Id
                            join d in _context.Voos on a.IdVoo equals d.Id
                            join e in _context.Aeronaves on a.IdAeronave equals e.Id

                            select new PlanoVooListResponse
                            {
                                Id = a.Id,
                                AeroportoOrigemNome = b.Nome,
                                AeroportoOrigemSigla = b.Sigla,
                                AeroportoDestinoNome = c.Nome,
                                AeroportoDestinoSigla = c.Sigla,
                                VooNumero = d.Numero,
                                VooData = d.Data,
                                VooHorario = d.Horario,
                                AeronaveMatricula = e.Matricula,
                                AeronaveTipo = e.Tipo
                            });

            return query;
        }
    }
}
