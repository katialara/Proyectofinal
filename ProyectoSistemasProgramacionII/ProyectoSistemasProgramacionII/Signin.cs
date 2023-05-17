using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemasProgramacionII
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            Conexion obj1 = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)//Registrarse
        {
            Conexion obj2 = new Conexion();
            MessageBox.Show(obj2.RegistrarUsuario(textBoxU.Text, textBoxN.Text, textBoxC.Text, textBoxT.Text, textBoxContra.Text));
        }
    }
}
