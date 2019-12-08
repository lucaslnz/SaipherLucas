using SaipherLucas.Api.Controllers.Base;
using SaipherLucas.Domain.Arguments.PlanoVoo;
using SaipherLucas.Domain.Interface.Services;
using SaipherLucas.Infra.Persistence;
using SaipherLucas.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SaipherLucas.Api.Controllers
{
    [RoutePrefix("api/PlanoVoo")]
    public class PlanoVooController : BaseController
    {
        private readonly IServicePlanoVoo _servicePlanoVoo;

        public PlanoVooController(IServicePlanoVoo servicePlanoVoo, IUnitOfWork unityOfWork) : base(unityOfWork)
        {
            _servicePlanoVoo = servicePlanoVoo;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarPlanoVooRequest request)
        {
            try
            {
                var response = _servicePlanoVoo.Adicionar(request);
                return await ResponseAsync(response, _servicePlanoVoo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarPlanoVooRequest request)
        {
            try
            {
                var response = _servicePlanoVoo.Alterar(request);
                return await ResponseAsync(response, _servicePlanoVoo);
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
                var response = _servicePlanoVoo.Excluir(Id);
                return await ResponseAsync(response, _servicePlanoVoo);
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
                var response = _servicePlanoVoo.Listar();
                return await ResponseAsync(response, _servicePlanoVoo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}