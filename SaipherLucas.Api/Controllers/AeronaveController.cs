using SaipherLucas.Api.Controllers.Base;
using SaipherLucas.Domain.Arguments.Aeronave;
using SaipherLucas.Domain.Interface.Services;
using SaipherLucas.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SaipherLucas.Api.Controllers
{
    [RoutePrefix("api/Aeronave")]
    public class AeronaveController : BaseController
    {
        private readonly IServiceAeronave _serviceAeronave;

        public AeronaveController(IServiceAeronave serviceAeronave, IUnitOfWork unityOfWork) : base(unityOfWork)
        {
            _serviceAeronave = serviceAeronave;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarAeronaveRequest request)
        {
            try
            {
                var response = _serviceAeronave.Adicionar(request);
                return await ResponseAsync(response, _serviceAeronave);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarAeronaveRequest request)
        {
            try
            {
                var response = _serviceAeronave.Alterar(request);
                return await ResponseAsync(response, _serviceAeronave);
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
                var response = _serviceAeronave.Excluir(Id);
                return await ResponseAsync(response, _serviceAeronave);
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
                var response = _serviceAeronave.Listar();
                return await ResponseAsync(response, _serviceAeronave);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}