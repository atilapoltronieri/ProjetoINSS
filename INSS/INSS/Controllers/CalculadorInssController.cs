using INSS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace INSS.Controllers
{
    [RoutePrefix("api/CalculadorInss")]
    public class CalculadorInssController : ApiController
    {
        [HttpGet]
        [Route("CalcularInss")]
        public HttpResponseMessage CalcularInss(DateTime pData, decimal pSalario)
        {
            try
            {
                decimal retorno = new CalculadorInssService().CalcularDescontoInss(pData, pSalario);
                return Request.CreateResponse(HttpStatusCode.OK, retorno);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Erro na ação CalcularInss: " + e.Message);
            }
        }
    }
}