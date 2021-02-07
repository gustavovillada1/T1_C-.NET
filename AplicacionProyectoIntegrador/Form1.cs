using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionProyectoIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<String> region, codigoDaneDepartamento, departamento, codigoDaneMunicipio, municipio;

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnImportarDatos_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Codigo para abrir y leer archivo
                label4.Text = openFileDialog1.FileName;

                string [] csvReaded = System.IO.File.ReadAllLines(@label4.Text);

                region = new List<string>();
                codigoDaneDepartamento = new List<string>();
                departamento = new List<string>();
                codigoDaneMunicipio = new List<string>();
                municipio = new List<string>();

                for (int i = 1; i < csvReaded.Length - 5; i++)
                {

                    string[] rowData = csvReaded[i].Split(',');
                    for(int j = 0; j < rowData.Length; j++)
                    {

                        region.Add(rowData[0]);
                        codigoDaneDepartamento.Add(rowData[1]);
                        departamento.Add(rowData[2]);
                        codigoDaneMunicipio.Add(rowData[3]);
                        municipio.Add(rowData[4]);
                        //Adicionamos nuevo renglon
                        int n = dataGridView1.Rows.Add();

                        //Colocamos la información
                        dataGridView1.Rows[n].Cells[0].Value = rowData[0];
                        dataGridView1.Rows[n].Cells[1].Value = rowData[1];
                        dataGridView1.Rows[n].Cells[2].Value = rowData[2];
                        dataGridView1.Rows[n].Cells[3].Value = rowData[3];
                        dataGridView1.Rows[n].Cells[4].Value = rowData[4];

                        //llenarTabla(region, codigoDaneDepartamento, departamento, codigoDaneMunicipio, municipio);
                    }
                }
                List<String> deps = new List<String>();

                for (int i = 0; i < departamento.Count; i++)
                {

                    String departamentos = departamento[i];
                    if (listContainString(departamentos, deps)==false)
                    {
                        deps.Add(departamentos);
                        cboxFiltrarTabla.Items.Add(departamentos);
                    }
                }


            }


        }

        private bool listContainString(String stringsito, List<String> listaCheck)
        {

                for(int j=0; j < listaCheck.Count;j++)
                {
                    if (stringsito == listaCheck[j])
                    {
                    return true;
                    }
                }

            
            return false;
        }


        private void llenarTabla(String selection)
        {
            dataGridView1.Rows.Clear();


            for(int i = 0; i < region.Count; i++)
            {
                if (selection == departamento[i])
                {

                    //Adicionamos nuevo renglon
                    int n = dataGridView1.Rows.Add();

                    //Colocamos la información
                    dataGridView1.Rows[n].Cells[0].Value = region[i];
                    dataGridView1.Rows[n].Cells[1].Value = codigoDaneDepartamento[i];
                    dataGridView1.Rows[n].Cells[2].Value = departamento[i];
                    dataGridView1.Rows[n].Cells[3].Value = codigoDaneMunicipio[i];
                    dataGridView1.Rows[n].Cells[4].Value = municipio[i];

                }

            }


        }

        private void convertirCSVtoCSharp()
        {

        }


        private void btnFiltrarTabla_Click(object sender, EventArgs e)
        {

            String selection = cboxFiltrarTabla.SelectedItem.ToString();
            llenarTabla(selection);
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            Form grafiquita = new Form2(this.municipio);
            grafiquita.Show();
                
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
