using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafeTDD
{
    internal class Azucarero
    {
        int cantidadDeAzucar { get; set; }

        public Azucarero(int cantidadDeAzucar) 
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }

        public void setCantidadDeAzucar(int param1)
        {
            cantidadDeAzucar = param1;
        }

        public int getCantidadDeAzucar()
        {
            return cantidadDeAzucar;
        }

        public bool hasAzucar(int cantidadDeAzucar)
        {
            if (this.cantidadDeAzucar >= cantidadDeAzucar)
            {
                return true;
            }

            return false;
        }

        public void giveAzucar(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar -= cantidadDeAzucar;
        }

    }
}
