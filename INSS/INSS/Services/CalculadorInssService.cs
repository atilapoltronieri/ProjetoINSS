using INSS.Interfaces;
using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INSS.Services
{
    public class CalculadorInssService
    {
        public decimal CalcularDescontoInss(DateTime pData, decimal pSalario)
        {
            decimal desconto;

            ICalculadorInss calculadorInssInterface = new CalculadorInssModel();
            desconto = calculadorInssInterface.CalcularDesconto(pData, pSalario);

            return Convert.ToDecimal(desconto.ToString("n2"));
        }
    }
}