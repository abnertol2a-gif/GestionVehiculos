using System;

namespace GestionVehiculos
{
    public class Auto : Vehiculo
    {
        public int Cilindraje { get; set; }

        public Auto(string marca, string modelo, int anio, int cilindraje)
            : base(marca, modelo, anio)
        {
            Cilindraje = cilindraje;
        }

        public override double CalcularImpuesto()
        {
            return (Cilindraje * 0.05) * Anio;
        }
    }
}
