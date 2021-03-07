using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Restourant_APP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pedido Restourant");
                     
            Pedido pedido = new Pedido();

            int op;

            do
            {
                Console.WriteLine("Ingrese la Opcion deseada:\n 1)Cafe\n 2)Lagrima\n 3)Finalizar pedido"); // opcines de productos
                Console.WriteLine(">>");

                 op = int.Parse(Console.ReadLine());

                if (op < 1 || op > 3) // verificador de opciones 
                {
                    Console.WriteLine("ingrese una opcion correcta!! \n-------------\n");
                }

                //Console.WriteLine($"opcion elegidad {op}");
            
                switch (op)
                {
                    case 1:
                        {
                            string name = "Cafe";
                            Console.WriteLine(name);

                            Console.WriteLine("Ingrese Cantidad de compra:");
                            int cantidad = int.Parse(Console.ReadLine());

                            pedido.agregarPedido(name, cantidad); // Metodo para agregar pedido

                            Console.WriteLine("Productos ingresado correctamente");

                            Console.WriteLine("desea Continuar agregando productos? S(1)/N(0)"); // Para saber si desea agregar mas productos o no 
                            int cont = int.Parse(Console.ReadLine());

                            if (cont == 1) // logica para salir del loop o no 
                            {
                                op = 0;
                            } else if (cont == 0)
                            {
                                Console.WriteLine("------------------Detalle de Compra----------------------");
                                op = 3;
                            }

                            break;
                        }

                    case 2:
                        {
                            string name = "Lagrima";
                            Console.WriteLine(name);

                            Console.WriteLine("Ingrese Cantidad de compra:");
                            int cantidad = int.Parse(Console.ReadLine());

                            pedido.agregarPedido(name, cantidad);

                            Console.WriteLine("Productos ingresado correctamente");

                            Console.WriteLine("desea Continuar agregando productos? S(1)/N(0)"); // Para saber si desea agregar mas productos o no 
                            int cont = int.Parse(Console.ReadLine());

                            if (cont == 1) // logica para salir del loop o no 
                            {
                                op = 0;
                            }
                            else if (cont == 0)
                            {
                                Console.WriteLine("------------------Detalle de Compra----------------------");
                                op = 3;
                            }

                            break;
                        }
                }
            } while (op != 3);

            if (op == 3)
            {
                if (pedido.pedido.Count == 0) // lista vacia verificador
                {
                    Console.WriteLine("No ha ingresado ningun producto!!");
                } else
                {
                    foreach (var p in pedido.pedido) // iteracion de la lista o coleccion pedido
                    {
                        Console.WriteLine($"Detalle del pedido: {p.name} // {p.cantidad}");
                        Console.WriteLine("Valor de Compra: {0}", p.subtotal);
                    }

                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"el Total del pedido es: {pedido.Total}"); // muestra del total
                }
               
            }

            Console.ReadKey();
        }
    }
}
