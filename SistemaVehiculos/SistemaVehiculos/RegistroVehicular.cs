using System;
using System.Collections.Generic;

namespace GestionVehiculos
{
    public class RegistroVehicular
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void AgregarVehiculo(Vehiculo v)
        {
            vehiculos.Add(v);
        }

        public void MostrarImpuestos()
        {
            Console.WriteLine("=== Impuestos de Vehículos ===");
            foreach (var v in vehiculos)
            {
                Console.WriteLine($"{v} → Impuesto: Q{v.CalcularImpuesto():0.00}");
            }
        }

        public void ListarVehiculos()
        {
            Console.WriteLine("=== Lista de Vehículos Registrados ===");
            foreach (var v in vehiculos)
            {
                Console.WriteLine(v);
            }
        }
    }
}
