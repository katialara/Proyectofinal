namespace ProyectoSistemasProgramacionII
{
    partial class Compilador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCompilar = new System.Windows.Forms.Button();
            this.BtnCargarArchivo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.ListBoxPALABRAS = new System.Windows.Forms.ListBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label3 = new System.Windows.Forms.Label();
            this.ListBoxStrings = new System.Windows.Forms.ListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ListBoxReales = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ListBoxEnteras = new System.Windows.Forms.ListBox();
            this.txtidentificadores = new System.Windows.Forms.Label();
            this.txtpalabrasr = new System.Windows.Forms.Label();
            this.txtarchivos = new System.Windows.Forms.Label();
            this.txtarchivoe = new System.Windows.Forms.Label();
            this.listBoxIds = new System.Windows.Forms.ListBox();
            this.listBoxEntrada = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCompilar
            // 
            this.BtnCompilar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCompilar.Location = new System.Drawing.Point(930, 23);
            this.BtnCompilar.Name = "BtnCompilar";
            this.BtnCompilar.Size = new System.Drawing.Size(75, 23);
            this.BtnCompilar.TabIndex = 0;
            this.BtnCompilar.Text = "Compilar";
            this.BtnCompilar.UseVisualStyleBackColor = false;
            this.BtnCompilar.Click += new System.EventHandler(this.BtnCompilar_Click);
            // 
            // BtnCargarArchivo
            // 
            this.BtnCargarArchivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCargarArchivo.Location = new System.Drawing.Point(1011, 23);
            this.BtnCargarArchivo.Name = "BtnCargarArchivo";
            this.BtnCargarArchivo.Size = new System.Drawing.Size(75, 23);
            this.BtnCargarArchivo.TabIndex = 1;
            this.BtnCargarArchivo.Text = "Cargar archivo";
            this.BtnCargarArchivo.UseVisualStyleBackColor = false;
            this.BtnCargarArchivo.Click += new System.EventHandler(this.BtnCargarArchivo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(1093, 23);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ListBoxPALABRAS
            // 
            this.ListBoxPALABRAS.FormattingEnabled = true;
            this.ListBoxPALABRAS.Location = new System.Drawing.Point(528, 88);
            this.ListBoxPALABRAS.Name = "ListBoxPALABRAS";
            this.ListBoxPALABRAS.Size = new System.Drawing.Size(142, 381);
            this.ListBoxPALABRAS.TabIndex = 63;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGridView1.Location = new System.Drawing.Point(220, 87);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(302, 381);
            this.DataGridView1.TabIndex = 62;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Token";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(1147, 71);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 14);
            this.Label3.TabIndex = 61;
            this.Label3.Text = "Ctes Strings";
            // 
            // ListBoxStrings
            // 
            this.ListBoxStrings.FormattingEnabled = true;
            this.ListBoxStrings.Location = new System.Drawing.Point(1105, 87);
            this.ListBoxStrings.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxStrings.Name = "ListBoxStrings";
            this.ListBoxStrings.Size = new System.Drawing.Size(156, 381);
            this.ListBoxStrings.TabIndex = 60;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(993, 71);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 14);
            this.Label2.TabIndex = 59;
            this.Label2.Text = "Ctes Reales";
            // 
            // ListBoxReales
            // 
            this.ListBoxReales.FormattingEnabled = true;
            this.ListBoxReales.Location = new System.Drawing.Point(962, 87);
            this.ListBoxReales.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxReales.Name = "ListBoxReales";
            this.ListBoxReales.Size = new System.Drawing.Size(127, 381);
            this.ListBoxReales.TabIndex = 58;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(847, 71);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 14);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "Ctes Enteras";
            // 
            // ListBoxEnteras
            // 
            this.ListBoxEnteras.FormattingEnabled = true;
            this.ListBoxEnteras.Location = new System.Drawing.Point(820, 87);
            this.ListBoxEnteras.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxEnteras.Name = "ListBoxEnteras";
            this.ListBoxEnteras.Size = new System.Drawing.Size(127, 381);
            this.ListBoxEnteras.TabIndex = 56;
            // 
            // txtidentificadores
            // 
            this.txtidentificadores.AutoSize = true;
            this.txtidentificadores.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentificadores.Location = new System.Drawing.Point(695, 71);
            this.txtidentificadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtidentificadores.Name = "txtidentificadores";
            this.txtidentificadores.Size = new System.Drawing.Size(85, 14);
            this.txtidentificadores.TabIndex = 55;
            this.txtidentificadores.Text = "Identificadores";
            // 
            // txtpalabrasr
            // 
            this.txtpalabrasr.AutoSize = true;
            this.txtpalabrasr.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalabrasr.Location = new System.Drawing.Point(534, 71);
            this.txtpalabrasr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtpalabrasr.Name = "txtpalabrasr";
            this.txtpalabrasr.Size = new System.Drawing.Size(108, 14);
            this.txtpalabrasr.TabIndex = 54;
            this.txtpalabrasr.Text = "Palabras reservadas";
            // 
            // txtarchivos
            // 
            this.txtarchivos.AutoSize = true;
            this.txtarchivos.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarchivos.Location = new System.Drawing.Point(323, 71);
            this.txtarchivos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtarchivos.Name = "txtarchivos";
            this.txtarchivos.Size = new System.Drawing.Size(94, 14);
            this.txtarchivos.TabIndex = 53;
            this.txtarchivos.Text = "Archivo de salida";
            // 
            // txtarchivoe
            // 
            this.txtarchivoe.AutoSize = true;
            this.txtarchivoe.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarchivoe.Location = new System.Drawing.Point(-108, 62);
            this.txtarchivoe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtarchivoe.Name = "txtarchivoe";
            this.txtarchivoe.Size = new System.Drawing.Size(105, 14);
            this.txtarchivoe.TabIndex = 52;
            this.txtarchivoe.Text = "Archivo de entrada";
            // 
            // listBoxIds
            // 
            this.listBoxIds.FormattingEnabled = true;
            this.listBoxIds.Location = new System.Drawing.Point(678, 87);
            this.listBoxIds.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxIds.Name = "listBoxIds";
            this.listBoxIds.Size = new System.Drawing.Size(127, 381);
            this.listBoxIds.TabIndex = 51;
            // 
            // listBoxEntrada
            // 
            this.listBoxEntrada.FormattingEnabled = true;
            this.listBoxEntrada.Location = new System.Drawing.Point(6, 87);
            this.listBoxEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEntrada.Name = "listBoxEntrada";
            this.listBoxEntrada.Size = new System.Drawing.Size(203, 381);
            this.listBoxEntrada.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(817, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 66;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGuardar.Location = new System.Drawing.Point(1174, 23);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 67;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // Compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 522);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListBoxPALABRAS);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ListBoxStrings);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ListBoxReales);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ListBoxEnteras);
            this.Controls.Add(this.txtidentificadores);
            this.Controls.Add(this.txtpalabrasr);
            this.Controls.Add(this.txtarchivos);
            this.Controls.Add(this.txtarchivoe);
            this.Controls.Add(this.listBoxIds);
            this.Controls.Add(this.listBoxEntrada);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCargarArchivo);
            this.Controls.Add(this.BtnCompilar);
            this.Name = "Compilador";
            this.Text = "Compilador";
            this.Load += new System.EventHandler(this.Compilador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompilar;
        private System.Windows.Forms.Button BtnCargarArchivo;
        private System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.ListBox ListBoxPALABRAS;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ListBox ListBoxStrings;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ListBox ListBoxReales;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListBox ListBoxEnteras;
        private System.Windows.Forms.Label txtidentificadores;
        private System.Windows.Forms.Label txtpalabrasr;
        private System.Windows.Forms.Label txtarchivos;
        private System.Windows.Forms.Label txtarchivoe;
        private System.Windows.Forms.ListBox listBoxIds;
        private System.Windows.Forms.ListBox listBoxEntrada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnGuardar;
    }
}