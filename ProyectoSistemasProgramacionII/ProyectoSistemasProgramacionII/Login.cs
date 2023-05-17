using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemasProgramacionII
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            ////if el usuario es correcto por medio de la bd
            this.Hide();
            Compilador compi = new Compilador();
            compi.Show();

            DatosL.variablelenguaje = comboBox1.SelectedItem.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin sign = new Signin();
            sign.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compilador compilador = new Compilador();
            compilador.IdLenguaje = (comboBox1.SelectedIndex + 1).ToString();
            compilador.IdUsuario = idUsuario;
            compilador.Visible = true;
            Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BD llenar = new BD();
            foreach (DataRow lenguajes in llenar.consulta("select nombre from lenguajes").Rows)
            {
                comboBox1.Items.Add(lenguajes["nombre"]);

            }
            comboBox1.SelectedIndex = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}