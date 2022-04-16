using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSolemne
{

    public class Evento {
        //Orden de Evento: Electronica, Rock, Folk
        private int _valorEntrada;
        private string _tipoEvento = String.Empty;

        //Constructor
        public Evento(int evento) {

            switch (evento) {

                case 1:
                    //Electronica
                    _tipoEvento = "Electronica";
                    _valorEntrada = 15000;
                    break;
                case 2:
                    //Rock
                    _tipoEvento = "Rock";
                    _valorEntrada = 50000;
                    break;
                case 3:
                    //Folk
                    _tipoEvento = "Folk";
                    _valorEntrada = 10000;
                    break;
            }
        
        }

        //Encapsulamiento
        public int ValorEntrada { get => _valorEntrada; set => _valorEntrada = value; }
        public string TipoEvento { get => _tipoEvento; set => _tipoEvento = value; }

    }

  
}
