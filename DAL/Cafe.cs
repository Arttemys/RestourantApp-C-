using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Cafe : Products
    {
        private decimal precioCafe;

        public decimal Precio
        {
            get {
                precioCafe = 60;
                return precioCafe; }
            set { precioCafe = value; }
        }

    }
}
