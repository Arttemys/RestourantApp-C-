using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Lagrima : Products
    {
        private decimal precioLagrima;

        public decimal Precio
        {
            get
            {
                precioLagrima = 65;
                return precioLagrima;
            }
            set { precioLagrima = value; }
        }
    }
}
