using SaipherLucas.Domain.Arguments.Base;
using SaipherLucas.Domain.Arguments.PlanoVoo;
using SaipherLucas.Domain.Entities;
using SaipherLucas.Domain.Interface.Repositories;
using SaipherLucas.Domain.Interface.Services;
using SaipherLucas.Domain.Resources;
using SaipherLucas.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SaipherLucas.Domain.Services
{
    public class ServicePlanoVoo :  ServiceBase, IServicePlanoVoo
    {
        private readonly IRepositoryPlanoVoo _repositoryPlanoVoo;

        public ServicePlanoVoo()
        {

        }

        public ServicePlanoVoo(IRepositoryPlanoVoo repositoryPlanoVoo)
        {
            this._repositoryPlanoVoo = repositoryPlanoVoo;
        }

        public AdicionarPlanoVooResponse Adicionar(AdicionarPlanoVooRequest request)
        {
            if (!VerificaRequest(request, "AdicionarPlanoVooRequest"))
                return null;

            PlanoVoo planovoo = new PlanoVoo(request.IdAeroportoOrigem, request.IdAeroportoDestino, request.IdAeronave, request.IdVoo);

            AddNotifications(planovoo);

            if (this.IsInvalid())
                return null;

            planovoo = _repositoryPlanoVoo.Adicionar(planovoo);

            return (AdicionarPlanoVooResponse)planovoo;
        }

        public AlterarPlanoVooResponse Alterar(AlterarPlanoVooRequest request)
        {
            if (!VerificaRequest(request, "AlterarPlanoVooRequest"))
                return null;

            PlanoVoo planovoo = _repositoryPlanoVoo.ObterPorId(request.Id);

            if(planovoo == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            planovoo.AlterarPlanoVoo(request.IdAeroportoOrigem, request.IdAeroportoDestino, request.IdAeronave, request.IdVoo);

            AddNotifications(planovoo);

            if (this.IsInvalid())
                return null;

            return (AlterarPlanoVooResponse)planovoo;
        }

        public BaseResponse Excluir(Guid id)
        {
            if (!VerificaRequest(id, "Id"))
                return null;
            
            PlanoVoo planovoo = _repositoryPlanoVoo.ObterPorId(id);

            if(planovoo == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            _repositoryPlanoVoo.Remover(planovoo);

            return new BaseResponse();
        }

        public IEnumerable<PlanoVooResponse> Listar()
        {
            //_repositoryPlanoVoo.Listar().ToList().Select(planovoo => (PlanoVooResponse)planovoo).ToList();

            return _repositoryPlanoVoo.ListarPlanos().ToList();
        }
    }
}
