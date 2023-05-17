using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemasProgramacionII
{
    public partial class Exportar : Form
    {
        public Exportar()
        {
            InitializeComponent();
        }
        private void exportar_Load(object sender, EventArgs e)
        {
            BD fuente = new BD();
            dataGridView1.DataSource = fuente.consulta("select U.nombre as Usuario,Len.nombre as Lenguaje,L.fecha as Fecha,L.archivo as Archivo_salida from log as L,usuarios as U,lenguajes as Len where L.IdUsuario = U.idUsuario and Len.idLenguaje = L.IdLenguaje");
            DataTable usuarios = fuente.consulta("select nombre from usuarios");
            for (int i = 0; i < usuarios.Rows.Count; i++)
            {
                comboBox1.Items.Add(usuarios.Rows[i]["nombre"]);
            }
            comboBox1.SelectedIndex = 0;
            DataTable lenguajes = fuente.consulta("select nombre from lenguajes");
            for (int i = 0; i < lenguajes.Rows.Count; i++)
            {
                comboBox2.Items.Add(lenguajes.Rows[i]["nombre"]);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.ShowDialog();
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (DataGridViewRow linea in dataGridView1.Rows)
                {
                    sw.WriteLine(linea.Cells["Usuario"].Value + " " + linea.Cells["Lenguaje"].Value + " " + linea.Cells["Fecha"].Value + " " + linea.Cells["Archivo_salida"].Value);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.DefaultExt = "csv";
                saveFileDialog1.ShowDialog();
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (DataGridViewRow linea in dataGridView1.Rows)
                {
                    sw.WriteLine(linea.Cells["Usuario"].Value + "," + linea.Cells["Lenguaje"].Value + "," + linea.Cells["Fecha"].Value + "," + linea.Cells["Archivo_salida"].Value);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(saveFileDialog1.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BD filtrar = new BD();
            string query = "select U.nombre as Usuario,Len.nombre as Lenguaje,L.fecha as Fecha,L.archivo as Archivo_salida from log as L,usuarios as U,lenguajes as Len where L.IdUsuario = U.idUsuario and Len.idLenguaje = L.IdLenguaje";
            if (checkBox1.Checked) query += " and U.Nombre='" + comboBox1.Text + "'";
            if (checkBox2.Checked) query += " and Len.Nombre='" + comboBox2.Text + "'";
            if (checkBox3.Checked) query += " and CONVERT(VARCHAR(8),L.fecha,112) between '" + dateTimePicker1.Value.Date.ToString("yyyyddMM") + "' and '" + dateTimePicker2.Value.Date.ToString("yyyyddMM") + "'";
            dataGridView1.DataSource = filtrar.consulta(query);
        }
}
