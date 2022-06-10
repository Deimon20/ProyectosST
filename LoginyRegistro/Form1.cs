using System.Windows.Forms;

namespace Autenticacion
{
    public partial class Form1 : Form
    {
        Conexion conexion = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //El boton verifica con la bd si el usuario ingresado es correcto
            int result = conexion.Login(txt_user.Text, txt_pass.Text);
            if (result == 1) {
                MessageBox.Show("Acceso Correcto! \n Bienvenido " + txt_user.Text, "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Form2 menu = new Form2();
                this.Hide();
                menu.ShowDialog();
            } else if (result == 0)
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecto \n Intente nuevamente.", "Autenticación", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_user.Clear();
                txt_pass.Clear();
                txt_user.Focus();
            }
        }
    }
}