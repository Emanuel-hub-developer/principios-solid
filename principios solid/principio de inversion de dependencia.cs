using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace principios_solid
{
    //internal class principio_de_inversion_de_dependencia
    //{
    //}


    public interface IClienteCorreo
    {
        void Enviar(string destino, string mensaje);
    }

    
    public class SmtpCliente : IClienteCorreo
    {
        public void Enviar(string destino, string mensaje)
        {
            
            Console.WriteLine($"Correo enviado a {destino}: {mensaje}");
        }
    }

    public class EnvioDeCorreo
    {
        private readonly IClienteCorreo clienteCorreo;

        public EnvioDeCorreo(IClienteCorreo clienteCorreo)
        {
            this.clienteCorreo = clienteCorreo;
        }

        public void EnviarCorreo(string destino, string mensaje)
        {
            clienteCorreo.Enviar(destino, mensaje);
        }
    }
}
