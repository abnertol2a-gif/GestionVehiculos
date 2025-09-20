using System;

namespace GestionVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroVehicular registro = new RegistroVehicular();

            // Vehículos de ejemplo
            registro.AgregarVehiculo(new Auto("Toyota", "Corolla", 2015, 1800));
            registro.AgregarVehiculo(new Motocicleta("Honda", "CBR", 2018, 600));
            registro.AgregarVehiculo(new Camion("Volvo", "FH", 2010, 20));
            registro.AgregarVehiculo(new Auto("Mazda", "3", 2020, 2000));
            registro.AgregarVehiculo(new Motocicleta("Yamaha", "R15", 2022, 155));

            int opcion;
            do
            {
                Console.WriteLine("\n=== Sistema de Gestión de Vehículos ===");
                Console.WriteLine("1. Listar vehículos");
                Console.WriteLine("2. Mostrar impuestos");
                Console.WriteLine("3. Agregar vehículo");
                Console.WriteLine("4. Buscar vehículos por marca");
                Console.WriteLine("5. Calcular total de impuestos");

                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        registro.ListarVehiculos();
                        break;
                    case 2:
                        registro.MostrarImpuestos();
                        break;
                    case 3:
                        AgregarVehiculoMenu(registro);
                        break;
                    case 4:
                        Console.Write("Ingrese la marca a buscar: ");
                        string marca = Console.ReadLine();
                        registro.BuscarPorMarca(marca);
                        break;
                    case 5:
                        registro.CalcularTotalImpuestos();
                        break;

                }
            } while (opcion != 0);
        }

        static void AgregarVehiculoMenu(RegistroVehicular registro)
        {
            Console.WriteLine("\nSeleccione tipo de vehículo:");
            Console.WriteLine("1. Auto");
            Console.WriteLine("2. Motocicleta");
            Console.WriteLine("3. Camión");
            int tipo = int.Parse(Console.ReadLine());

            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Año: ");
            int anio = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    Console.Write("Cilindraje: ");
                    int cilindrajeAuto = int.Parse(Console.ReadLine());
                    registro.AgregarVehiculo(new Auto(marca, modelo, anio, cilindrajeAuto));
                    break;
                case 2:
                    Console.Write("Cilindraje: ");
                    int cilindrajeMoto = int.Parse(Console.ReadLine());
                    registro.AgregarVehiculo(new Motocicleta(marca, modelo, anio, cilindrajeMoto));
                    break;
                case 3:
                    Console.Write("Capacidad en toneladas: ");
                    int capacidad = int.Parse(Console.ReadLine());
                    registro.AgregarVehiculo(new Camion(marca, modelo, anio, capacidad));
                    break;
            }

            Console.WriteLine("Vehículo agregado con éxito.");
        }
    }
}
