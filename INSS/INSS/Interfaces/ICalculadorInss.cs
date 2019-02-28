﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INSS.Interfaces
{
    public interface ICalculadorInss
    {
        /// <summary>
        /// Deve retornar o deconto do INSS aplicado ao salário, na determinada data.
        /// </summary>
        decimal CalcularDesconto(DateTime data, decimal salario);
    }
}