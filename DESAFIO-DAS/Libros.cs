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
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Libros_Load(object sender, EventArgs e)
        {
            //Las colecciones de datos
            string[] series = { "CISCO CCNA", "WINDOWS SERVER", "FORTINET ADMINISTRATOR" };
            int[] puntos = { 80, 60, 35 };

            //Cambiar color 
            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("LIBROS MÁS LEIDOS Y BUSCADOS");
            for (int i = 0; i < series.Length; i++)
            {
                //Titulos
                Series serie = chart1.Series.Add(series[i]);

                //Cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }
    }
}
