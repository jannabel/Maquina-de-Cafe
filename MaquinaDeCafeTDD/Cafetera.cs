using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafeTDD
{
    internal class Cafetera
    {
        int cantidadCafe { get; set; }

        public Cafetera(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }
        
        public void setCantidadDeCafe(int param1)
        {
            this.cantidadCafe = param1;
        }

        public int getCantidadDeCafe()
        {
            return this.cantidadCafe;
        } 

        public bool hasCafe(int cantidadCafe)
        {
            if (this.cantidadCafe >= cantidadCafe)
            {
                return true;
            }
            return false;
        }

        public void giveCafe(int cantidadCafe)
        {
            this.cantidadCafe -= cantidadCafe;
        }

    }
}
