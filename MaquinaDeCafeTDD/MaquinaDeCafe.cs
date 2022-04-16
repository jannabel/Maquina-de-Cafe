namespace MaquinaDeCafeTDD
{
    internal class MaquinadeCafe
    {
        Cafetera cafe;
        public Vaso vasosPequenos;
        public Vaso vasosMedianos;
        public Vaso vasosGrandes;

        Azucarero azucarero;

        public Vaso getTipoVaso(string tipoDeVaso)
        {
            switch (tipoDeVaso)
            {
                case "pequeno":
                    return this.vasosPequenos;
                case "mediano":
                    return this.vasosMedianos;
                case "grande":
                    return this.vasosGrandes;

                default:
                    return null;
            }
        }

        public string getVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            if (!HayVasos(tipoDeVaso, cantidadDeVasos)) return "No hay Vasos";
            else if (!HayCafe(tipoDeVaso)) return "No hay Cafe";
            else if (!HayAzucar(cantidadDeAzucar)) return "No hay Azucar";

            return "Felicitaciones";
        }
        bool HayVasos(Vaso tipoDeVaso, int cantidadDeVasos)
        {
            if (tipoDeVaso.hasVasos(cantidadDeVasos)) { tipoDeVaso.giveVasos(cantidadDeVasos); return true; }
            return false;
        }

        bool HayCafe(Vaso vaso)
        {
            if (cafe.hasCafe(vaso.getContenido())) { cafe.giveCafe(vaso.getContenido()); return true; }
            return false;
        }

        bool HayAzucar(int azucar)
        {
            if (azucarero.hasAzucar(azucar)) { azucarero.giveAzucar(azucar); return true; }
            return false;
        }

        public void setVasosPequeno(Vaso vasosPequenos) { this.vasosPequenos = vasosPequenos; }

        public void setvasosMediano(Vaso vasosMediano) { this.vasosMedianos = vasosMediano;}

        public void setvasosGrandes(Vaso vasosGrandes) { this.vasosGrandes = vasosGrandes; }

        public void setAzucarero(Azucarero azucarero) { this.azucarero = azucarero; }

        public void setCafetera(Cafetera cafe) { this.cafe = cafe; }

        public Cafetera getCafetera() { return this.cafe; }

        public Vaso getVasosPequeno() { return this.vasosPequenos; }

        public Vaso setvasosMediano() { return this.vasosMedianos; }

        public Vaso getvasosGrandes() { return this.vasosGrandes; }

        public Azucarero getAzucarero() { return this.azucarero; }
    }
}
