using prmToolkit.NotificationPattern.Extensions;
using SaipherLucas.Domain.Arguments.Aeroporto;
using SaipherLucas.Domain.Arguments.Base;
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
    public class ServiceAeroporto : ServiceBase, IServiceAeroporto
    {
        private readonly IRepositoryAeroporto _repositoryAeroporto;
        public ServiceAeroporto()
        {
        }
        public ServiceAeroporto(IRepositoryAeroporto repositoryAeroporto)
        {
            _repositoryAeroporto = repositoryAeroporto;
        }

        public AdicionarAeroportoResponse Adicionar(AdicionarAeroportoRequest request)
        {
            //if(request == null)
            //    AddNotification("AdicionarAeroportoRequest", Message.X0_E_OBRIGATORIO.ToFormat("AdicionarAeroportoRequest"));
            if (!VerificaRequest(request, "AdicionarAeroportoRequest"))
                return null;

            if (_repositoryAeroporto.Existe(x => x.Sigla == request.Sigla))
            {
                AddNotification("Sigla", Message.JA_EXISTE_OUTRO_X0_CADASTRADO_COM_A_X1_X2.ToFormat("aeroporto", "sigla", request.Sigla));
                return null;
            }

            Aeroporto aeroporto = new Aeroporto(request.Sigla, request.Nome);

            AddNotifications(aeroporto);

            if (this.IsInvalid())
                return null;

            aeroporto = _repositoryAeroporto.Adicionar(aeroporto);

            return (AdicionarAeroportoResponse)aeroporto;
        }

        public AlterarAeroportoResponse Alterar(AlterarAeroportoRequest request)
        {
            //if (request == null)
            //    AddNotification("AlterarAeroportoRequest", Message.X0_E_OBRIGATORIO.ToFormat("AlterarAeroportoRequest"));
            if (!VerificaRequest(request, "AlterarAeroportoRequest"))
                return null;

            Aeroporto aeroporto = _repositoryAeroporto.ObterPorId(request.Id);

            if(aeroporto == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            if (_repositoryAeroporto.Existe(x => x.Sigla == request.Sigla && x.Id != request.Id))
            {
                AddNotification("Sigla", Message.JA_EXISTE_OUTRO_X0_CADASTRADO_COM_A_X1_X2.ToFormat("aeroporto","sigla", request.Sigla));
                return null;
            }

            aeroporto.AlterarAeroporto(request.Sigla, request.Nome);

            AddNotifications(aeroporto);

            if (this.IsInvalid())
                return null;

            _repositoryAeroporto.Editar(aeroporto);

            return (AlterarAeroportoResponse)aeroporto;
        }

        public BaseResponse Excluir(Guid id)
        {
            if (!VerificaRequest(id, "Id"))
                return null;

            Aeroporto aeroporto = _repositoryAeroporto.ObterPorId(id);

            if (aeroporto == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            _repositoryAeroporto.Remover(aeroporto);

            return new BaseResponse();
        }

        public IEnumerable<AeroportoResponse> Listar()
        {
            return _repositoryAeroporto.Listar().ToList().Select(aeroporto => (AeroportoResponse)aeroporto).ToList();
        }
    }
}
