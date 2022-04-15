//Ejercicio de Sistema Credito
namespace SistemaCredito
{
    public class Cliente
    {
        private int _rut;
        private int _dv;
        private string _primerNombre, _primerApellido, _segundoApellido;
        private int _telefono;
        private string _direccionParticular, _direccionLaboral;
        private double _sueldo;

        public Cliente()
        {
            // validar.. previamente
            _rut = 0;
            _dv = 0;
            _primerNombre = "Sin nombre.";
            _primerApellido = "Sin Apellido.";
            _segundoApellido = "Sin apellido.";
            _telefono = 0;
            _direccionParticular = "Sin dirección particular.";
            _direccionLaboral = "Sin dirección laboral.";
            _sueldo = 0.0;
        }

        public Cliente(int rut, int dv,
                       string primerNombre, string primerApellido, string segundoApellido,
                       int telefono,
                       string direccionParticular, string direccionLaboral,
                       double sueldo)
        {
            _rut = rut;
            _dv = dv;
            _primerNombre = primerNombre;
            _primerApellido = primerApellido;
            _segundoApellido = segundoApellido;
            _telefono = telefono;
            _direccionParticular = direccionParticular;
            _direccionLaboral = direccionLaboral;
            _sueldo = sueldo;
        }

        // Encapsulamiento

        public int Rut { get => _rut; set => _rut = value; }
        public int Dv { get => _dv; set => _dv = value; }
        public string PrimerNombre { get => _primerNombre; set => _primerNombre = value; }
        public string PrimerApellido { get => _primerApellido; set => _primerApellido = value; }
        public string SegundoApellido { get => _segundoApellido; set => _segundoApellido = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }
        public string DireccionParticular { get => _direccionParticular; set => _direccionParticular = value; }
        public string DireccionLaboral { get => _direccionLaboral; set => _direccionLaboral = value; }
        public double Sueldo { get => _sueldo; set => _sueldo = value; }

        //Metodos
        public void ImprimirInfoCliente()
        {

            Console.WriteLine("RUT: " + _rut);
            Console.WriteLine("Nombre completo: " + _primerNombre + " " + _primerApellido + " " + _segundoApellido);
            Console.WriteLine("Telefono: " + _telefono);
            Console.WriteLine("Dirección Particular: " + _direccionParticular);
            Console.WriteLine("Dirección Laboral: " + _direccionLaboral);
            Console.WriteLine("Sueldo: $" + _sueldo);

        }

        public bool LargoRut()
        {

            string Srut = _rut.ToString();
            int minRut = 7;

            //V = RUT SEA MENOR QUE 7 INVALIDO
            if (Srut.Length < minRut)
            {
                return false;
            }
            else
            {
                return true;
            }


        }


        public int ValidarRut()
        {
            //Validar largo del rut: 20968555

            int _suma = 0;
            int _ver = 0;

            //rut = _rut;
            if (LargoRut())
            {

                //Verificar dv
                string Srut = _rut.ToString();
                int[] serie = { 2, 3, 4, 5, 6, 7, 2, 3 };
                char[] rutInv = Srut.ToCharArray();
                Array.Reverse(rutInv);
                //21075795 -> 59757012
                for (int i = 0; i < rutInv.Length; i++)
                {
                    _suma = (int)Char.GetNumericValue(rutInv[i]) * serie[i];
                    _ver += _suma;

                }

                _ver = _ver % 11;
                _ver = 11 - _ver;

               

                if (_ver == _dv)
                {

                    return _ver;


                }
                else
                {
                    return -4;
                }

                

            }
            else
            {


                return -2;



            }
        }

    }
}




