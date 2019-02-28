using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INSS.Models
{
    public class TabelaCalculoInss
    {
        #region Propriedades

        public Dictionary<decimal, decimal> tabelaInss { get; set; }
        public decimal descontoTeto { get; set; }

        #endregion Propriedades

        public TabelaCalculoInss(DateTime pDataBase, decimal pSalario)
        {
            PreencherTabelaInss(pDataBase, pSalario);
        }

        private void PreencherTabelaInss(DateTime pDataBase, decimal pSalario)
        {
            tabelaInss = new Dictionary<decimal, decimal>();
            descontoTeto = 0M;

            if (pDataBase.Year == 2011)
            {
                #region Tabela Cálculo 2011
                tabelaInss.Add(1106.90M, 0.08M);
                tabelaInss.Add(1844.83M, 0.09M);
                tabelaInss.Add(3689.66M, 0.11M);
                descontoTeto = 405.86M;
                #endregion Tabela Cálculo 2011
            }
            else if (pDataBase.Year == 2012)
            {
                #region Tabela Cálculo 2012
                tabelaInss.Add(1000.00M, 0.07M);
                tabelaInss.Add(1500.00M, 0.08M);
                tabelaInss.Add(3000.00M, 0.09M);
                tabelaInss.Add(4000.00M, 0.11M);
                descontoTeto = 500M;
                #endregion Tabela Cálculo 2012
            }
        }
    }
}