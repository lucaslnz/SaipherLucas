using SaipherLucas.Api.Controllers.Base;
using SaipherLucas.Domain.Arguments.Aeroporto;
using SaipherLucas.Domain.Interface.Services;
using SaipherLucas.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SaipherLucas.Api.Controllers
{
    [RoutePrefix("api/Aeroporto")]
    public class AeroportoController : BaseController
    {
        private readonly IServiceAeroporto _serviceAeroporto;

        public AeroportoController(IServiceAeroporto serviceAeroporto, IUnitOfWork unityOfWork) : base(unityOfWork)
        {
            _serviceAeroporto = serviceAeroporto;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarAeroportoRequest request)
        {
            try
            {
                var response = _serviceAeroporto.Adicionar(request);
                return await ResponseAsync(response, _serviceAeroporto);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarAeroportoRequest request)
        {
            try
            {
                var response = _serviceAeroporto.Alterar(request);
                return await ResponseAsync(response, _serviceAeroporto);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Excluir")]
        [HttpDelete]
        public async Task<HttpResponseMessage> Excluir(Guid Id)
        {
            try
            {
                var response = _serviceAeroporto.Excluir(Id);
                return await ResponseAsync(response, _serviceAeroporto);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceAeroporto.Listar();
                return await ResponseAsync(response, _serviceAeroporto);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}