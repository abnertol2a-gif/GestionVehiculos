using System;

namespace GestionVehiculos
{
    public class Camion : Vehiculo
    {
        public int CapacidadToneladas { get; set; }

        public Camion(string marca, string modelo, int anio, int capacidadToneladas)
            : base(marca, modelo, anio)
        {
            CapacidadToneladas = capacidadToneladas;
        }

        public override double CalcularImpuesto()
        {
            int antiguedad = DateTime.Now.Year - Anio;
            return (CapacidadToneladas * 100) + (antiguedad * 50);
        }
    }
}
