using System;
using System.Collections.Generic;
using System.Text;

namespace LucroCerto
{
    internal struct Produto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal LucroDesejado { get; set; }

        public decimal CalculaValorComLucro(decimal valor, decimal LucroDesejado)
        {

            decimal valorComLucro = valor / (((LucroDesejado / 100) - 1) * -1);
            return valorComLucro;
        }
    }
}
