using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Products
    {
        public string name { get; set; }

        public int cantidad { get; set; }

        public decimal subtotal { get; set; }

        //metodo para calcular subtotal..

        public decimal calcularSubTotal(int cantidad, decimal precio)
        {
            decimal subtotal = cantidad * precio;

            return subtotal;
        }

    }
}
