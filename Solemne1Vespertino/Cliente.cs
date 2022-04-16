using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSolemne
{
    public enum MetodoPago { 
        
        Efectivo = 1,
        Credito  = 2,
        Cheque = 3

    }
    public class Cliente
    {
        //Declaración de Variables
        private string _nombre, _apellido;
        private int _cantEntradas;
        private MetodoPago _metodoPago;
        private bool _vip;

        //Constructor
        public Cliente(string nombre, string apellido, int cantEntradas,MetodoPago metodo, bool vip) { 
        
            this._nombre = nombre;
            this._apellido = apellido;
            this._cantEntradas = cantEntradas;
            this._metodoPago = metodo;
            this._vip = vip;
            
        
        }

        //Encapsulamiento
        public string Nombre { get => _nombre; set => _nombre = value;} 
        public string Apellido { get => _apellido; set => _apellido = value;}
        public int CantEntradas { get => _cantEntradas; set => _cantEntradas = value;}
        public MetodoPago MetodoPago { get => _metodoPago; set => _metodoPago = value;}
        public bool VIP { get => _vip; set => _vip = value; }

    }
}
