using System;

namespace GestionVehiculos
{
    public class Motocicleta : Vehiculo
    {
        public int Cilindraje { get; set; }

        public Motocicleta(string marca, string modelo, int anio, int cilindraje)
            : base(marca, modelo, anio)
        {
            Cilindraje = cilindraje;
        }

        public override double CalcularImpuesto()
        {
            return Cilindraje * 0.03;
        }
    }
}
