namespace AplicacionProyectoIntegrador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDaneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartamentoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDaneMunicipioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportarDatos = new System.Windows.Forms.Button();
            this.cboxFiltrarTabla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerarGrafico = new System.Windows.Forms.Button();
            this.btnFiltrarTabla = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegionColumn,
            this.CodigoDaneColumn,
            this.DepartamentoColumn,
            this.CodigoDaneMunicipioColumn,
            this.MunicipioColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // RegionColumn
            // 
            this.RegionColumn.HeaderText = "REGIÓN";
            this.RegionColumn.Name = "RegionColumn";
            // 
            // CodigoDaneColumn
            // 
            this.CodigoDaneColumn.HeaderText = "CÓDIGO DANE";
            this.CodigoDaneColumn.Name = "CodigoDaneColumn";
            // 
            // DepartamentoColumn
            // 
            this.DepartamentoColumn.HeaderText = "DEPARTAMENTO";
            this.DepartamentoColumn.Name = "DepartamentoColumn";
            // 
            // CodigoDaneMunicipioColumn
            // 
            this.CodigoDaneMunicipioColumn.HeaderText = "CÓDIGO DANE";
            this.CodigoDaneMunicipioColumn.Name = "CodigoDaneMunicipioColumn";
            // 
            // MunicipioColumn
            // 
            this.MunicipioColumn.HeaderText = "MUNICIPIO";
            this.MunicipioColumn.Name = "MunicipioColumn";
            // 
            // btnImportarDatos
            // 
            this.btnImportarDatos.Location = new System.Drawing.Point(12, 12);
            this.btnImportarDatos.Name = "btnImportarDatos";
            this.btnImportarDatos.Size = new System.Drawing.Size(116, 23);
            this.btnImportarDatos.TabIndex = 1;
            this.btnImportarDatos.Text = "Importar Datos";
            this.btnImportarDatos.UseVisualStyleBackColor = true;
            this.btnImportarDatos.Click += new System.EventHandler(this.btnImportarDatos_Click);
            // 
            // cboxFiltrarTabla
            // 
            this.cboxFiltrarTabla.FormattingEnabled = true;
            this.cboxFiltrarTabla.Location = new System.Drawing.Point(89, 103);
            this.cboxFiltrarTabla.Name = "cboxFiltrarTabla";
            this.cboxFiltrarTabla.Size = new System.Drawing.Size(121, 21);
            this.cboxFiltrarTabla.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "_________________________________________________________________________________" +
    "_________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reporte 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reporte 2";
            // 
            // btnGenerarGrafico
            // 
            this.btnGenerarGrafico.Location = new System.Drawing.Point(338, 101);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(123, 23);
            this.btnGenerarGrafico.TabIndex = 6;
            this.btnGenerarGrafico.Text = "Generar Grafico";
            this.btnGenerarGrafico.UseVisualStyleBackColor = true;
            this.btnGenerarGrafico.Click += new System.EventHandler(this.btnGenerarGrafico_Click);
            // 
            // btnFiltrarTabla
            // 
            this.btnFiltrarTabla.Location = new System.Drawing.Point(87, 130);
            this.btnFiltrarTabla.Name = "btnFiltrarTabla";
            this.btnFiltrarTabla.Size = new System.Drawing.Size(123, 23);
            this.btnFiltrarTabla.TabIndex = 7;
            this.btnFiltrarTabla.Text = "Filtrar Tabla";
            this.btnFiltrarTabla.UseVisualStyleBackColor = true;
            this.btnFiltrarTabla.Click += new System.EventHandler(this.btnFiltrarTabla_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Archivos CSV|*.csv|Todos los archivos|*.*\".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Importado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFiltrarTabla);
            this.Controls.Add(this.btnGenerarGrafico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxFiltrarTabla);
            this.Controls.Add(this.btnImportarDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDaneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartamentoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDaneMunicipioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioColumn;
        private System.Windows.Forms.Button btnImportarDatos;
        private System.Windows.Forms.ComboBox cboxFiltrarTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerarGrafico;
        private System.Windows.Forms.Button btnFiltrarTabla;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
    }
}

