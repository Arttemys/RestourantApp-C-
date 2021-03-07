using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class Pedido 
    {
        public List<Products> pedido = new List<Products>(); // creo la coleccion

        public void agregarPedido(string name, int cantidad)
        {
            Products products = new Products();


            //If para controlar y calcular bien el subtotal, segun el producto elegido creo un objecto de ese mismo
            if (name == "Cafe")
            {
                Cafe cafe = new Cafe();
                products.subtotal = products.calcularSubTotal(cantidad, cafe.Precio);
            }
            else if (name == "Lagrima")
            {
                Lagrima lagrima = new Lagrima();
                products.subtotal = products.calcularSubTotal(cantidad, lagrima.Precio);
            }

            products.name = name;
            products.cantidad = cantidad;

            // agrego a la lista
            pedido.Add(products);
        }

        private decimal myVar;

        public decimal Total
        {
            get {
                myVar = pedido.Sum(c => c.subtotal);
                return myVar; }
            set { myVar = value; }
        }


    }
}
