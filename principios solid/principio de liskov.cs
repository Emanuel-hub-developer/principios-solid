using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principios_solid
{
    //internal class principio_de_liskov
    //{
    //}


    public class Vehiculo
    {
        public virtual void Conducir()
        {
            //Logica de conduccion
        }

    }

    public interface IConMaletero
    {
        void AbrirMaletero();
    }

    public class Bicicleta : Vehiculo
    {
        public override void Conducir()
        {
            //Conducir bicicleta
        }
    }

    public class Coche : Vehiculo,IConMaletero
    {
        public override void Conducir()
        {
            //Conducir Coche
        }

        public  void AbrirMaletero()
        {
            //Logica para abrir maletero
        }
    }
}
