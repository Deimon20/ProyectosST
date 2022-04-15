//Ejercicio de Sistema Credito
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCredito
{
    public class Credito
    {
        private int _id;
        private double _monto;
        private int _cuotas;
        private Cliente _cliente;

        public Credito(double monto, int cuotas, Cliente cliente)
        {
            _id = 0;
            _monto = monto;
            _cuotas = cuotas;
            _cliente = cliente;
        }

        public Credito(Cliente cliente) {
            _id = 0;
            _monto = 0.0;
            _cuotas = 0;
            _cliente = cliente;
        
        
        }

        //Encapsulamiento
        public int ID { get => _id; set => _id = value; }
        public double Monto { get => _monto; set => _monto = value; }
        public int Cuotas { get => _cuotas; set => _cuotas = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }

        //Metodos

        public bool ValidarMonto(double monto, double sueldo) {
            sueldo = _cliente.Sueldo;
            return monto <= (sueldo * 1.5);
        
        }

        public bool ValidarCuotas(int cuotas) {

            return cuotas >= 6;
        
        }

        public void ImprimirInfoCredito() {
            double sueldo = _cliente.Sueldo;
            Console.WriteLine("ID del crédito: " + _id);
            Console.WriteLine("Monto del crédito: " + _monto);
            Console.WriteLine("Cuotas: " + _cuotas); 
            double interes = CalculoInteres(_monto, _cuotas, sueldo);
            Console.WriteLine("Interés total: " + interes);
        
        }
        
        public double CalculoInteres(double monto, int cuotas, double sueldo) {

            monto = _monto;
            cuotas = _cuotas;
            sueldo = _cliente.Sueldo;
            double _interesMensual = 0.0185;
            double _interesExcedente = 0.03;
            double _in = monto;
            double _x;
           

            if (ValidarMonto(monto, sueldo))
            {
                if (!ValidarCuotas(cuotas))
                {

                    return -2.0;

                }
                else if (cuotas >= 6 && cuotas <= 48)
                {
                    for (int i = 0; i < cuotas; i++)
                    {

                        _x = _in * _interesMensual;
                        _in = _in + _x;
                        _x = 0;

                    }
                    return Math.Round(_in);



                }
                else if (cuotas >= 49)
                {

                    for (int i = 0; i < cuotas; i++)
                    {

                        _x = _in * _interesExcedente;
                        _in = _in + _x;
                        _x = 0;

                    }
                    return Math.Round(_in);

                }
                else {
                    return -3.0;
                }
      


            }
            else {

                return -1.0;
            
            }






        }
    }
}
