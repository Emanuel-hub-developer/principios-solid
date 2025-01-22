using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principios_solid
{
    //internal class principio_de_segregacion_de_interfaces
    //{
    //}

    public interface ITrabajo
    {
        void Trabajar();

    }

    public interface IDescansar
    {
        void Descansar();
    }

    public interface IComer
    {
        void Comer();
    }

    public class Programador : ITrabajo,IDescansar,IComer
    {
        public void Trabajar()
        {
            //Escribiendo codigo...
        }

        public void Descansar()
        {
            //Descansando...
        }

        public void Comer()
        {
            //Comiendo
        }
    }

    public class Gerente : ITrabajo,IDescansar,IComer
    {
        public void Trabajar()
        {
            //Gestionando proyectos...
        }

        public void Descansar()
        {
            //Descansando...
        }

        public void Comer()
        {
            //Comiendo...
        }
    }


}
