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

namespace DESAFIO_DAS
{
    public partial class Lenguajes : Form
    {
        public Lenguajes()
        {
            InitializeComponent();
        }

        private void Lenguajes_Load(object sender, EventArgs e)
        {
            //Las colecciones de datos
            string[] series = { "Python", "C#", "Java" };
            int[] puntos = { 90,75,65};

            //Cambiar color 
            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("Lenguajes de programacion");
            for (int i=0; i<series.Length;i++)
            {
                //Titulos
                Series serie= chart1.Series.Add(series[i]);

                //Cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);

            }
        }
    }
}
