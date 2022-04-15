//Ejercicio de Sistema Credito
namespace SistemaCredito
{
    public class Program
    {
        private static List<Cliente> clientes = new List<Cliente>(5);
        private static List<Credito> creditos = new List<Credito>(5);
        private static int breaker = 0;
        private static int idC = 0;
        public static void Main(string[] args)
        {
            while (breaker == 0)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Banco Think©");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("¿Qué desea realizar?");
                Console.WriteLine("1. Registro de creditos.");
                Console.WriteLine("2. Ver creditos creados.");
                Console.WriteLine("3. Calculo de interes");
                Console.WriteLine("4. Salir.");
                Console.WriteLine("--------------------------------------------");
                string _seleccion;
                _seleccion = Console.ReadLine();
                Console.Clear();


                switch (_seleccion)
                {
                    case "1":

                        //Datos del solicitante
                        Console.WriteLine("Ingrese su RUT (No Digito Verificador, Sin puntos, Sin guión):");
                        int rut = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el digito verificador (Si es K ingrese 10, Si es 0 ingrese 11):");
                        int dv = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su nombre:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su primer apellido:");
                        string pA = Console.ReadLine();
                        Console.WriteLine("Ingrese su segundo apellido:");
                        string sA = Console.ReadLine();
                        Console.WriteLine("Ingrese su telefono:");
                        int telefono = int.Parse(Console.ReadLine());
                        Console.WriteLine("Direccion Particular:");
                        string dP = Console.ReadLine();
                        Console.WriteLine("Direccion Laboral:");
                        string dL = Console.ReadLine();
                        Console.WriteLine("Sueldo:");
                        double sueldo = double.Parse(Console.ReadLine());

                        Cliente usuario = new Cliente(rut, dv, nombre, pA, sA, telefono, dP, dL, sueldo);

                        while (usuario.ValidarRut() == -4)
                        {

                            Console.WriteLine("!RUT y/o Digito Verificador no válidos!");
                            Console.WriteLine("Ingrese su RUT nuevamente:");
                            rut = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese su Digito Verificador nuevamente:");
                            dv = int.Parse(Console.ReadLine());
                            usuario.Rut = rut;
                            usuario.Dv = dv;

                        }
                        clientes.Add(usuario);

                        //Creacion de credito
                        idC++;
                        Credito nuevoCredito = new Credito(usuario);
                        Console.Clear();
                        Console.WriteLine("Monto del credito a solicitar:");
                        double monto = double.Parse(Console.ReadLine());
                        if (!nuevoCredito.ValidarMonto(monto, usuario.Sueldo))
                        {

                            while (!nuevoCredito.ValidarMonto(monto, usuario.Sueldo))
                            {
                                Console.WriteLine("Monto inválido, excede el 150%; Intente nuevamente:");
                                monto = double.Parse(Console.ReadLine());
                            }

                        }
                        Console.WriteLine("Ingrese la cantidad de cuotas (Mínimo 6):");
                        int cuotas = int.Parse(Console.ReadLine());
                        if (!nuevoCredito.ValidarCuotas(cuotas))
                        {

                            while (!nuevoCredito.ValidarCuotas(cuotas))
                            {
                                Console.WriteLine("Número de cuotas inválido, Mínimo 6; Intente nuevamente:");
                                cuotas = int.Parse(Console.ReadLine());
                            }
                        }
                        nuevoCredito.ID = idC;
                        nuevoCredito.Monto = monto;
                        nuevoCredito.Cuotas = cuotas;

                        Console.Clear();
                        Console.WriteLine("Credito registrado correctamente.");
                        creditos.Add(nuevoCredito);
                        break;

                    case "2":

                        for (int i = 0; i < clientes.Count; i++)
                        {
                            Console.WriteLine("--------------------------------------------");
                            clientes[i].ImprimirInfoCliente();
                            Console.WriteLine("////////////////////////////////////////////");
                            creditos[i].ImprimirInfoCredito();

                        }
                        break;

                    case "3":
                        Cliente ej = new Cliente();
                        Console.WriteLine("Ingrese un sueldo:");
                        double sU = double.Parse(Console.ReadLine());
                        ej.Sueldo = sU;
                        Console.WriteLine("Ingrese un monto:");
                        double Mo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese cuotas:");
                        int Cu = int.Parse(Console.ReadLine());
                        Credito calculo = new Credito(Mo, Cu, ej);
                        calculo.CalculoInteres(Mo, Cu, sU);
                        calculo.ImprimirInfoCredito();
                        break;


                    case "4":
                        breaker = 1;
                        break;



                }
            }
        }
    }
}
