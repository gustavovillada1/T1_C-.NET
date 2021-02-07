using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AplicacionProyectoIntegrador
{
    public partial class Form2 : Form
    {


        private List<string> municipios;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<string> municipios)
        {
            InitializeComponent();
            this.municipios = municipios;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] series = { "Municipio","Isla","Area no municipal" };



            int cantidadMunicipios = calcularCantidadPalabra("Municipio");
            int cantidadIslas = calcularCantidadPalabra("Isla");
            int cantidadAreaNoMunicipal = calcularCantidadPalabra("Área no municipalizada");

            int[] puntos = { cantidadMunicipios,cantidadIslas, cantidadAreaNoMunicipal };

            chartMunicipios.Palette = ChartColorPalette.Pastel;

            //chartMunicipios.Titles.Add("Municipios");

            for(int i=0; i < series.Length; i++)
            {
                Series serie = chartMunicipios.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);

            }
            chartMunicipios.Series["Municipio"].ChartType = SeriesChartType.Bar;
            chartMunicipios.Series["Isla"].ChartType = SeriesChartType.Bar;
            chartMunicipios.Series["Area no municipal"].ChartType = SeriesChartType.Bar;

        }

        private int calcularCantidadPalabra(String palabra)
        {
            int cantidad = 0;
            for(int i = 0; i < this.municipios.Count; i++)
            {
                if (this.municipios[i] == palabra)
                {
                    cantidad += 1;
                }
            }
            return cantidad;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
