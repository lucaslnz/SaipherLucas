using SaipherLucas.Domain.Arguments.Base;
using SaipherLucas.Domain.Arguments.Voo;
using SaipherLucas.Domain.Entities;
using SaipherLucas.Domain.Interface.Repositories;
using SaipherLucas.Domain.Interface.Services;
using SaipherLucas.Domain.Resources;
using SaipherLucas.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaipherLucas.Domain.Services
{
    public class ServiceVoo : ServiceBase, IServiceVoo
    {
        private readonly IRepositoryVoo _repositoryVoo;
        public ServiceVoo()
        {
        }
        public ServiceVoo(IRepositoryVoo repositoryVoo)
        {
            _repositoryVoo = repositoryVoo;
        }

        public AdicionarVooResponse Adicionar(AdicionarVooRequest request)
        {
            if (!VerificaRequest(request, "AdicionarVooRequest"))
                return null;

            Voo voo = new Voo(request.Numero, request.Data, request.Horario);

            AddNotifications(voo);

            if (this.IsInvalid())
                return null;

            voo = _repositoryVoo.Adicionar(voo);

            return (AdicionarVooResponse)voo;
        }

        public AlterarVooResponse Alterar(AlterarVooRequest request)
        {
            if (!VerificaRequest(request, "AlterarVooRequest"))
                return null;

            Voo voo = _repositoryVoo.ObterPorId(request.Id);

            if(voo == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            voo.AlterarVoo(request.Numero, request.Data, request.Horario);

            AddNotifications(voo);

            if (this.IsInvalid())
                return null;

            _repositoryVoo.Editar(voo);

            return (AlterarVooResponse)voo;
        }

        public BaseResponse Excluir(Guid id)
        {
            if(!VerificaRequest(id, "Id"))
                return null;

            Voo voo = _repositoryVoo.ObterPorId(id);

            if (voo == null)
            {
                AddNotification("Excluir", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            _repositoryVoo.Remover(voo);

            return new BaseResponse();
        }

        public IEnumerable<VooResponse> Listar()
        {
            return _repositoryVoo.Listar().ToList().Select(voo => (VooResponse)voo).ToList();
        }
    }
}
