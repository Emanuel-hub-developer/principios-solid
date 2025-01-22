using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principios_solid
{
    
    public class Pedido
    {
       
        //SOLUCION

        public void CrearPedido(string cliente, string producto)
        {
            // Logica para crear un pedido

            Console.WriteLine($"Pedido creado para el cliente {cliente} con el producto {producto}.");
        }
    }

    public class EnviarPedido(Pedido pedido)
    {
        public void enviarPedido(string cliente, string direccion)
        {
            // Logica para enviar un pedido

            Console.WriteLine($"Pedido enviado a la direccion {direccion} para el cliente {cliente}.");
        }
    }


    public class ImprimirFactura(Pedido pedido)
    {
        public void imprimirFactura(string cliente, string producto)
        {
            // Logica para imprimir la factura

            Console.WriteLine($"Factura impresa para el cliente {cliente} con el producto {producto}.");
        }

    }

}
