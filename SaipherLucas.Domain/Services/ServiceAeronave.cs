using prmToolkit.NotificationPattern.Extensions;
using SaipherLucas.Domain.Arguments.Aeronave;
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
    public class ServiceAeronave : ServiceBase, IServiceAeronave
    {
        private readonly IRepositoryAeronave _repositoryAeronave;
        public ServiceAeronave()
        {
        }
        public ServiceAeronave(IRepositoryAeronave repositoryAeronave)
        {
            _repositoryAeronave = repositoryAeronave;
        }

        public AdicionarAeronaveResponse Adicionar(AdicionarAeronaveRequest request)
        {
            if (!VerificaRequest(request, "AdicionarAeronaveRequest"))
                return null;

            Aeronave aeronave = new Aeronave(request.Tipo, request.Matricula);

            AddNotifications(aeronave);

            if (_repositoryAeronave.Existe(x => x.Matricula == request.Matricula)) 
            {
                AddNotification("Matrícula", Message.JA_EXISTE_OUTRA_X0_CADASTRADA_COM_A_X1_X2.ToFormat("aeronave", "matrícula", request.Matricula));
                return null;
            }

            if (this.IsInvalid())
                return null;

            aeronave = _repositoryAeronave.Adicionar(aeronave);

            return (AdicionarAeronaveResponse)aeronave;
        }

        public AlterarAeronaveResponse Alterar(AlterarAeronaveRequest request)
        {
            if (!VerificaRequest(request, "AlterarAeronaveRequest"))
                return null;

            Aeronave aeronave = _repositoryAeronave.ObterPorId(request.Id);

            if (aeronave == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            if (_repositoryAeronave.Existe(x => x.Matricula == request.Matricula && x.Id != request.Id))
            {
                AddNotification("Matrícula", Message.JA_EXISTE_OUTRA_X0_CADASTRADA_COM_A_X1_X2.ToFormat("aeronave", "matrícula", request.Matricula));
                return null;
            }

            aeronave.AlterarAeronave(request.Tipo, request.Matricula);

            AddNotifications(aeronave);

            if (this.IsInvalid())
                return null;

            _repositoryAeronave.Editar(aeronave);

            return (AlterarAeronaveResponse)aeronave;
        }

        public BaseResponse Excluir(Guid id)
        {
            if (!VerificaRequest(id, "Id"))
                return null;

            Aeronave aeronave = _repositoryAeronave.ObterPorId(id);

            if (aeronave == null) 
            {
                AddNotification("Excluir", Message.DADOS_NAO_ENCONTRADOS);
                return null;    
            }

            _repositoryAeronave.Remover(aeronave);

            return new BaseResponse();
        }

        public IEnumerable<AeronaveResponse> Listar()
        {
            return _repositoryAeronave.Listar().ToList().Select(aeronave => (AeronaveResponse)aeronave).ToList();
        }
    }
}
