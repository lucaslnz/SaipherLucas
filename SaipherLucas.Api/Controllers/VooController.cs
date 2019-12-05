using SaipherLucas.Api.Controllers.Base;
using SaipherLucas.Domain.Arguments.Voo;
using SaipherLucas.Domain.Interface.Services;
using SaipherLucas.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SaipherLucas.Api.Controllers
{
    [RoutePrefix("api/Voo")]
    public class VooController : BaseController
    {
        private readonly IServiceVoo _serviceVoo;

        public VooController(IServiceVoo serviceVoo, IUnitOfWork unityOfWork) : base(unityOfWork)
        {
            _serviceVoo = serviceVoo;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarVooRequest request)
        {
            try
            {
                var response = _serviceVoo.Adicionar(request);
                return await ResponseAsync(response, _serviceVoo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarVooRequest request)
        {
            try
            {
                var response = _serviceVoo.Alterar(request);
                return await ResponseAsync(response, _serviceVoo);
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
                var response = _serviceVoo.Excluir(Id);
                return await ResponseAsync(response, _serviceVoo);
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
                var response = _serviceVoo.Listar();
                return await ResponseAsync(response, _serviceVoo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}