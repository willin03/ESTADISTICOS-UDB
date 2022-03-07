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
    public partial class Television : Form
    {
        public Television()
        {
            InitializeComponent();
        }

        private void Television_Load(object sender, EventArgs e)
        {
            //Las colecciones de datos
            string[] series = { "MR.ROBOT", "SCORPION", "THE GOOD DOCTOR" };
            int[] puntos = { 80, 60, 95 };

            //Cambiar color 
            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("PROGRAMAS DE TELEVISION CON MAS AUDIENCIA");
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
