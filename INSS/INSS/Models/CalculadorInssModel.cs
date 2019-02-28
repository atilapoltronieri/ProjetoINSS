using INSS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INSS.Models
{
    public class CalculadorInssModel : ICalculadorInss
    {
        public decimal CalcularDesconto(DateTime pData, decimal pSalario)
        {
            TabelaCalculoInss tabelaCalculo = new TabelaCalculoInss(pData, pSalario);

            return CalcularDesconto(tabelaCalculo, pSalario);
        }

        private decimal CalcularDesconto(TabelaCalculoInss pTabelaCalculo, decimal pSalario)
        {
            decimal retorno = 0M;

            if (pSalario == 0)
                return retorno;

            foreach (var item in pTabelaCalculo.tabelaInss)
            {
                if (pSalario <= item.Key)
                {
                    retorno = pSalario * item.Value;
                    break;
                }
            }

            if (retorno == 0M)
                retorno = pTabelaCalculo.descontoTeto;

            return retorno;
        }
    }
}