//Ejercicio Remuneraciones Electrolitos

namespace RemuneracionesElectrolitos {
    public class Program
    {
        private static List<Empleado> empleados = new List<Empleado>(10);

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Elija una opcion:\n");
                Console.WriteLine("1. Consultar usuario.");
                Console.WriteLine("2. Ingresar usuario.\n");
                Console.WriteLine("0. Salir\n");
                int peticion = 0;
                int.TryParse(Console.ReadLine(), out peticion);
                Console.Clear();
                switch (peticion)
                {
                    case 0:
                        // Salir
                        Console.WriteLine("Cerrando programa...");
                        return;
                    case 1:
                        // Consulta de datos
                        foreach(Empleado empleado in empleados){
                            Console.WriteLine("_________________________________");
                            Console.WriteLine("Nombre: " + empleado.Nombre);
                            Console.WriteLine("Tipo empleado: " + empleado.EmpleadoTipo.ToString());
                            Console.WriteLine("Sueldo: " + empleado.Sueldo);
                            Console.WriteLine("Horas trabajadas: " + empleado.Horas);
                            Console.WriteLine("Horas extra: " + empleado.HorasExtra);
                            if (empleado.Horas <= empleado.HorasMaximo)
                            {
                                Console.WriteLine("Monto horas normales: " + empleado.Horas * empleado.MontoHorasNormales);
                            }
                            else {
                                Console.WriteLine("Monto horas normales: " + empleado.HorasMaximo * empleado.MontoHorasNormales);
                            }
                           
                            Console.WriteLine("Monto horas extras: " + empleado.HorasExtra * empleado.MontoHorasExtras);
                            Console.WriteLine("_________________________________");
                        }
                        break;
                    case 2:
                        // Ingreso de datos
                        
                        Console.WriteLine("Ingrese nombre de usuario: ");
                        string name;
                        name = Console.ReadLine();
                        Console.WriteLine("\nIngrese el tipo de empleado: ");
                        Console.WriteLine("\n0: Jefe de Tienda" +
                                          "\n1: Vendedor de Tienda" +
                                          "\n2: Reponedor de Tienda");
                        TipoEmpleado emp = new TipoEmpleado();
                        int tipe = 0;
                        int.TryParse(Console.ReadLine(), out tipe);
                        switch (tipe){
                            case 0:
                                emp = TipoEmpleado.JefeTienda;
                                break;
                            case 1:
                                emp = TipoEmpleado.VendedorTienda;
                                break;
                            case 2:
                                emp = TipoEmpleado.ReponedorTienda;
                                break;
                            default:
                                Console.WriteLine("Tipo de empleado no válido");
                                return;
                        
                        }
                        Console.WriteLine("\nIngrese la cantidad de horas: ");
                        int h = 0;
                        int.TryParse(Console.ReadLine(), out h);

                        empleados.Add(new Empleado(h,emp,name));
                        break;

                  
                }
                
            }
        }
    }
}