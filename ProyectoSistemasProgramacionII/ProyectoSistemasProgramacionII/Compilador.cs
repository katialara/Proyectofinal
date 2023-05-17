using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ProyectoSistemasProgramacionII
{
    public partial class Compilador : Form
    {

        int columna;
        int estado;
        int[,] matriz = new int[12, 20];

        string wlinea, token, caracter;
        int direccion, posicion;
        bool encontro, espalabrareservada;
        //string archivo;

        public Compilador()
        {
            InitializeComponent();

        }



        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Compilador_Load(object sender, EventArgs e)
        {
            
            LeerMatrizEstados2();

        }

        void CargarPalabrasReservadas()
        {
            string ruta = "";
            textBox1.Text = DatosL.variablelenguaje;

            if (textBox1.Text == "Cobol")
            {
                ruta = "C:\\Users\\pauli\\source\\repos\\ProyectoSistemasProgramacionII\\ProyectoSistemasProgramacionII\\bin\\Debug\\Lenguajes\\BlocPRCobol.txt";
                MessageBox.Show("ruta" + ruta);

            }
            else if (textBox1.Text == "Visual Basic")
            {
                ruta = "C:\\Users\\pauli\\source\\repos\\ProyectoSistemasProgramacionII\\ProyectoSistemasProgramacionII\\bin\\Debug\\Lenguajes\\BlocPRVB.txt";
                MessageBox.Show("ruta" + ruta);
            }

            StreamReader leer = new StreamReader(ruta);
            while (leer.Peek() != -1)
            {
                string wlinea = leer.ReadLine();
                if (string.IsNullOrEmpty(wlinea))
                {
                    continue;
                }
                ListBoxPALABRAS.Items.Add(wlinea);
            }
        }

        private void BtnCompilar_Click(object sender, EventArgs e)
        {
            CargarPalabrasReservadas();
            int Renglon;
            Renglon = 0;

            while (Renglon < listBoxEntrada.Items.Count)
            {
                listBoxEntrada.SelectedIndex = Renglon;
                wlinea = listBoxEntrada.Text;
                BuscaTokens();
                Renglon = Renglon + 1;

            }
        }

        void BuscaReservadas()
        {
            int Renglon1;
            encontro = false;
            Renglon1 = 0;

            while ((!encontro) && (Renglon1 < ListBoxPALABRAS.Items.Count))
            {
                ListBoxPALABRAS.SelectedIndex = Renglon1;
                if (token.ToUpper() == ListBoxPALABRAS.Text.ToUpper())
                {
                    encontro = true;
                    direccion = Renglon1;
                    espalabrareservada = true;
                }
                direccion = Renglon1;
                Renglon1 = Renglon1 + 1;
            }
        }

        void BuscaIdentificadores()
        {
            int Renglon2;
            Renglon2 = 0;

            while ((!encontro) && (Renglon2 < listBoxIds.Items.Count))
            {
                listBoxIds.SelectedIndex = Renglon2;
                if (token.ToUpper() == listBoxIds.Text.ToUpper())
                {
                    encontro = true;
                }
                direccion = Renglon2;
                Renglon2 = Renglon2 + 1;
            }
            if (!encontro) {
                listBoxIds.Items.Add(token);
                direccion = Renglon2;
            }

        }
        void BuscaCEnteras()
        {
            int Renglon3;
            Renglon3 = 0;
            encontro = false;
            while ((!encontro) && (Renglon3 < ListBoxEnteras.Items.Count))
            {
                ListBoxEnteras.SelectedIndex = Renglon3;
                if (token.ToUpper() == ListBoxEnteras.Text.ToUpper())
                {
                    encontro = true;
                }
                direccion = Renglon3;
                Renglon3 = Renglon3 + 1;
            }
            if (!encontro)
            {
                ListBoxEnteras.Items.Add(token);
                direccion = Renglon3;
            }
        }

        void BuscaCReales()
        {
            int Renglon4;
            Renglon4 = 0;
            encontro = false;

            while ((!encontro) && (Renglon4 < ListBoxReales.Items.Count))
            {
                ListBoxReales.SelectedIndex = Renglon4;
                if (token.ToUpper() == ListBoxReales.Text.ToUpper())
                {
                    encontro = true;
                }
                direccion = Renglon4;
                Renglon4 = Renglon4 + 1;
            }
            if (!encontro)
            {
                ListBoxReales.Items.Add(token);
                direccion = Renglon4;
            }

        }
        void BuscaCStrings()
        {
            int Renglon5;
            Renglon5 = 0;
            encontro = false;

            while ((!encontro) && (Renglon5 < ListBoxStrings.Items.Count))
            {
                ListBoxStrings.SelectedIndex = Renglon5;
                if (token.ToUpper() == ListBoxStrings.Text.ToUpper())
                {
                    encontro = true;
                }
                direccion = Renglon5;
                Renglon5 = Renglon5 + 1;
            }
            if (!encontro)
            {
                ListBoxStrings.Items.Add(token);
                direccion = Renglon5;
            }
        }

        void BuscaTokens()
        {
            posicion = 1;
            token = "";
            estado = 0;
            int lugar;
            while (posicion <= wlinea.Length)
            {
                caracter = wlinea.Substring(posicion, 1);
                CalculaColumna();
                estado = matriz[estado, columna];
                if (estado >= 100)
                {
                    if (token.Length > 0)
                    {
                        ReconoceTokens();
                    }
                    if ((caracter.Length > 0) && (token.Length == 0))
                    {
                        ReconoceTokens();
                    }

                    estado = 0;
                    token = "";
                }
                else
                {
                    if (estado != 0)
                    {
                        token += caracter;
                    }
                }
                posicion = posicion + 1;
            }
            lugar = token.Length;
            if (estado == 6 && lugar <= token.Length)
            {
                if (caracter != "\"\"") //diferente de comillas
                {
                    MessageBox.Show("Las constantes strings deben de terminar con comillas dobles");
                }
            }

            if (estado != 0)
            {
                caracter = " ";
                CalculaColumna();
                estado = matriz[estado, columna];
                ReconoceTokens();
            }
        }
        void CalculaColumna()

        {
            if (caracter.ToCharArray()[0] >= 'A' && caracter.ToCharArray()[0] <= 'Z' || caracter.ToCharArray()[0] >= 'a' && caracter.ToCharArray()[0] <= 'z')

            {

                columna = 0;
            }
            if ((caracter.ToCharArray()[0] >= '0') && (caracter.ToCharArray()[0] <= '9')){
                columna = 1;
            }
            if (caracter == ".")
                {
                    columna = 2;
                }
                if (caracter == "\"\"")
                { //comillas
                    columna = 3;
                }
                if (caracter == "/")
                {
                    columna = 4;
                }
                if (caracter == "*")
                {
                    columna = 5;
                }
                if (caracter == "$")
                {
                    columna = 6;
                }
                if (caracter == ",")
                {
                    columna = 7;
                }
                if (caracter == ";")
                {
                    columna = 8;
                }
                if (caracter == "(")
                {
                    columna = 9;
                }
                if (caracter == ")")
                {
                    columna = 10;
                }
                if (caracter == "{")
                {
                    columna = 11;
                }
                if (caracter == "}")
                {
                    columna = 12;
                }
                if (caracter == "+")
                {
                    columna = 13;
                }
                if (caracter == "-")
                {
                    columna = 14;
                }
                if (caracter == "=")
                {
                    columna = 15;
                }
                if (caracter == "<")
                {
                    columna = 16;
                }
                if (caracter == ">")
                {
                    columna = 17;
                }
                if (caracter == "_")
                {
                    columna = 18;
                }
                if (caracter == " ")
                { //Espacio
                    columna = 19;

                }
            }
        

        void ReconoceTokens()
        {
            if (estado == 100)
            {
                espalabrareservada = false;
                BuscaReservadas();
                if (espalabrareservada)
                {
                    DataGridView1.Rows.Add(token, "PR", direccion);

                }
                else
                {
                    BuscaIdentificadores();
                    DataGridView1.Rows.Add(token, "ID", direccion);

                }
                posicion = posicion - 1;
            }
            if (estado == 101) {
                BuscaCEnteras();
                DataGridView1.Rows.Add(token, "Constante entera", direccion);
                posicion = posicion - 1; // 'estado aceptor con regresión
            }

            if (estado == 102)
            {
                BuscaCReales();
                DataGridView1.Rows.Add(token, "Constante real", direccion);
                posicion = posicion - 1; //estado aceptor con regresión
            }

            if (estado == 103) {
                token = token + caracter;
                BuscaCStrings();
                DataGridView1.Rows.Add(token, "Constante string", direccion);
            }

            if (estado == 104) { //'
                DataGridView1.Rows.Add(token, "Caracter especial");
                posicion = posicion - 1; //estado aceptor con regresión
            }

            if (estado == 105) {
                token = token + caracter;
                DataGridView1.Rows.Add(token, "Comentario");
            }

            if (estado == 106) { //$
                DataGridView1.Rows.Add(caracter, "Caracter especial");
            }

            if (estado == 107) { //,
                DataGridView1.Rows.Add(caracter, "Caracter especial");
            }

            if (estado == 108) { //;
                DataGridView1.Rows.Add(caracter, "Caracter especial");
            }

            if (estado == 109) { //(
                DataGridView1.Rows.Add(caracter, "Caracter especial");
            }

            if (estado == 110) { //)
                DataGridView1.Rows.Add(caracter, "Caracter especial");
            }

            if (estado == 111) { //{
                DataGridView1.Rows.Add(caracter, "Caracter especial");
            }

            if (estado == 112) { //}
                DataGridView1.Rows.Add(caracter, "Caracter especial");
            }

            if (estado == 113) { //+
                DataGridView1.Rows.Add(caracter, "Caracter especial");
            }

            if (estado == 114) { //-
        DataGridView1.Rows.Add(caracter, "Caracter especial");
                }

                if (estado == 115) { //=
                    DataGridView1.Rows.Add(caracter, "Caracter especial");
}

                if (estado == 116) { //<= 
                    token = token + caracter;
                    DataGridView1.Rows.Add(token, "Caracter especial");
              }

                if (estado == 117) { //<
                    DataGridView1.Rows.Add(token, "Caracter especial");
                    posicion = posicion - 1; //estado aceptor con regresión
              }

            if (estado == 118)
            { //<>
                token = token + caracter;
                DataGridView1.Rows.Add(token, "Caracter especial");
            }

            if (estado == 119)
            { //>=
                DataGridView1.Rows.Add(token, "Caracter especial");
                posicion = posicion - 1; //estado aceptor con regresión
            }

            if (estado == 120) { //>
                DataGridView1.Rows.Add(token, "Caracter especial");
                posicion = posicion - 1; //estado aceptor con regresión
            }

            if (estado == 121) { //*
                    DataGridView1.Rows.Add(caracter, "Caracter especial");
               }

                if (estado == 122) { //_
                    DataGridView1.Rows.Add(caracter, "Caracter especial");
               }
        }



        void LeerMatrizEstados2()
        {

            string ruta = "";
            string renglon;
            string[] datosRenglon;
            int estado = 0;
            int columna = 0;
            textBox1.Text = DatosL.variablelenguaje;
            
            ruta = "C:\\Users\\pauli\\source\\repos\\ProyectoSistemasProgramacionII\\ProyectoSistemasProgramacionII\\bin\\Debug\\Lenguajes\\BlocMatrizCobol.txt";
            StreamReader lector = new StreamReader(ruta);
            

            int variable = matriz.Length;
                      while (!lector.EndOfStream)
            {
                renglon = lector.ReadLine();
                datosRenglon = renglon.Split(',');
                for (columna = 0; columna < datosRenglon.Length; columna++)
                {
                       matriz[estado, columna] = Convert.ToInt32(datosRenglon[columna]);
                   // listBoxMatriz.Items.Add(matriz[estado, columna]);
                  //  MessageBox.Show("datosvector[" +columna+"]" +datosRenglon[columna]+ "y matriz ["+estado +"] [" +columna+"] " + matriz [estado, columna]).ToString();
                }
                estado += 1;
                
            }
            lector.Close();
        }

        private void BtnCargarArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
             string archivo;
             archivo = openFileDialog1.FileName;
            StreamReader fileReader = new StreamReader(archivo);

            while (!fileReader.EndOfStream)
            {
                wlinea = fileReader.ReadLine();
                listBoxEntrada.Items.Add(wlinea);
            }
        }
        



    }

}

