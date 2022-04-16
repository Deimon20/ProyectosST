namespace PracticaSolemne
{


    public class Solemne
    {

        public static void Main(string[] args)
        {

            bool breaker = false;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Sistema de Venta de Entradas");
            Console.WriteLine("------------------------------");
            while (breaker == false)
            {
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1. Comprar entradas");
                Console.WriteLine("0. Salir");
                Console.WriteLine("------------------------------");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("SALIENDO DEL PROGRAMA...");
                        breaker = true;
                        return;
                    case 1:
                        Console.WriteLine("Ingrese su nombre:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su apellido:");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Cantidad de entradas a comprar:");
                        int cantEntradas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Metodo de pago: 1. Efectivo  2.Credito  3.Cheque");
                        int mP = int.Parse(Console.ReadLine());
                        MetodoPago metodoPago = new MetodoPago();
                        switch (mP) {
                            case 1:
                                metodoPago = MetodoPago.Efectivo;
                                break;
                            case 2:
                                metodoPago = MetodoPago.Credito;
                                break;
                            case 3:
                                metodoPago = MetodoPago.Cheque;
                                break;
                        
                        }
                        Console.WriteLine("Es VIP: 1.Sí  2.No");
                        int s = int.Parse(Console.ReadLine());
                        bool vip = false;
                        switch (s)
                        {
                            case 1:
                                vip = true;
                                break;
                            case 2:
                                vip = false;
                                break;
                        }

                        Cliente usuario = new Cliente(nombre,apellido,cantEntradas,metodoPago, vip);
                        Console.Clear();

                        Console.WriteLine("¿Que tipo de evento asistira?");
                        Console.WriteLine("1. Electronica");
                        Console.WriteLine("2. Rock");
                        Console.WriteLine("3. Folk");
                        int ev = int.Parse(Console.ReadLine());

                        Evento concierto = new Evento(ev);
                        Console.Clear();

                        Ticket ticket = new Ticket();
                        ticket.Boleta(usuario, concierto);

                        break;

                }
            }




        }
    }


















}