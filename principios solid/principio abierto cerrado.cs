using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principios_solid
{
    //internal class principio_abierto_cerrado
    //{
    //}


    //Solucion
    public class CalculadoraDeDescuentos 
    {  

        public interface IDescuentos 
        {
            public double Precio { get; set; }
            
            public double CalcularDescuento();
            
        }    

        public class ClienteRegular : IDescuentos
        {
            public double Precio { get; set; }

            private double Descuento = 0.05;

            public double CalcularDescuento()
            {
                return Precio * Descuento;
            }

        }

        public class ClientePremium : IDescuentos
        {
            public double Precio { get; set; }

            private double Descuento = 0.1;
            public double CalcularDescuento()
            {
                return Precio * Descuento;
            }

        }
       
    }

}
