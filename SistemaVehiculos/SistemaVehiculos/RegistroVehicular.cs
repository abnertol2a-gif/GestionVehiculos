using System;
using System.Collections.Generic;
using System.Linq;

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

        // 🔹 Función extra 1: Buscar vehículos por marca
        public void BuscarPorMarca(string marca)
        {
            var encontrados = vehiculos.Where(v => v.Marca.Equals(marca, StringComparison.OrdinalIgnoreCase)).ToList();
            if (encontrados.Count == 0)
            {
                Console.WriteLine($"No se encontraron vehículos de la marca {marca}.");
            }
            else
            {
                Console.WriteLine($"Vehículos encontrados de la marca {marca}:");
                foreach (var v in encontrados)
                {
                    Console.WriteLine(v);
                }
            }
        }

        // 🔹 Función extra 2: Calcular total de impuestos
        public void CalcularTotalImpuestos()
        {
            double total = vehiculos.Sum(v => v.CalcularImpuesto());
            Console.WriteLine($"El total de impuestos a recaudar es: Q{total:0.00}");
        }
    }
}
