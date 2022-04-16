using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSolemne
{
    public class Ticket
    {
        public int CalculoPago(Cliente c, Evento e)
        {
            double total = 0;

            //1. Electronica
            if (e.TipoEvento == "Electronica" && c.CantEntradas <= 3 && c.MetodoPago == MetodoPago.Efectivo)
            {

                total = e.ValorEntrada * 1.20;

                total = total * c.CantEntradas;

                Math.Round(total);

                return (int)total;

            }
            else if (e.TipoEvento == "Electronica" && c.CantEntradas <= 3 && c.MetodoPago != MetodoPago.Efectivo)
            {

                total = e.ValorEntrada * 1.25;

                total *= c.CantEntradas;

                Math.Round(total);

                return (int)total;
            }
            else if (e.TipoEvento == "Electronica" && c.CantEntradas > 3 && c.CantEntradas < 10 && c.MetodoPago != MetodoPago.Cheque)
            {

                total = e.ValorEntrada * 1.15;

                total *= c.CantEntradas;

                Math.Round(total);

                return (int)total;

            }
            else if (e.TipoEvento == "Electronica" && c.CantEntradas > 3 && c.CantEntradas < 10 && c.MetodoPago == MetodoPago.Cheque)
            {
                total = e.ValorEntrada - (e.ValorEntrada * 0.03);

                total *= 1.15;

                total *= c.CantEntradas;

                Math.Round(total);

                return (int)total;

            }
            else if (e.TipoEvento == "Electronica" && c.CantEntradas > 10)
            {

                total = e.ValorEntrada * 1.05;

                total *= c.CantEntradas;

                total = total - (total * 0.02);

                Math.Round(total);

                return (int)total;

            }
            //2. Rock
            if (e.TipoEvento == "Rock" && c.CantEntradas <= 5)
            {

                total = e.ValorEntrada * 1.20;

                total *= c.CantEntradas;

                Math.Round(total);

                return (int)total;

            }
            else if (e.TipoEvento == "Rock" && c.CantEntradas > 5 && c.MetodoPago != MetodoPago.Credito)
            {
                total = e.ValorEntrada * 1.15;
                total *= c.CantEntradas;
                Math.Round(total);
                return (int)total;
            }
            else if (e.TipoEvento == "Rock" && c.CantEntradas > 5 && c.MetodoPago == MetodoPago.Credito) {

                total = e.ValorEntrada * c.CantEntradas;
                total = total - (total * 0.15);
                Math.Round(total);

                return (int)total;
            
            }
            //3. Folk
            if (e.TipoEvento == "Folk" && c.VIP == false)
            {
                return -420;

            }
            else if (e.TipoEvento == "Folk" && c.VIP == true) {
                total = e.ValorEntrada * 1.30;

                total *= c.CantEntradas;

                Math.Round(total);

                return (int)total;
            
            } else
            {

                return -1;
            }

                
        }

        public void Boleta(Cliente c, Evento e)
        {
            if (CalculoPago(c, e) != -420)
            {
                Console.WriteLine("-----------BOLETA-----------");
                Console.WriteLine("Nombre: " + c.Nombre + " " + c.Apellido);
                Console.WriteLine("Metodo De Pago: " + c.MetodoPago);
                Console.WriteLine("Evento: " + e.TipoEvento);
                if (c.VIP == true)
                {
                    Console.WriteLine("VIP?: Sí");
                }
                else
                {
                    Console.WriteLine("VIP?: No");
                }
                Console.WriteLine("Cantidad de Entradas Compradas: " + c.CantEntradas);
                Console.WriteLine("Total a pagar: $" + CalculoPago(c, e));
                Console.WriteLine("----------------------------");
            } else
            {
                Console.WriteLine("-----------ERROR-----------");
                Console.WriteLine("Usted no puede realizar la compra de entradas del evento Folk.");
                Console.WriteLine("Cliente no es VIP.");
                Console.WriteLine("---------------------------");
            }


        }
    }

}


    

