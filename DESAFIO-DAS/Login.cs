using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESAFIO_DAS
{
    public partial class Login : Form
    {

        Menu menu=new Menu();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] nombres = { "Carlos", "Manuel", "Ernesto", "Margarita", "Roxana" };
            string[] password = { "12345", "123", "111", "hola", "tesla" };


            if (nombres.Contains(txtUsuario.Text) && password.Contains(txtPassword.Text) && Array.IndexOf(nombres, txtUsuario.Text) ==
                Array.IndexOf(password, txtPassword.Text))
            {

                this.Hide();
                menu.Show();
            }
            else
            {

                MessageBox.Show("Usuario o Contraseña incorrecta");
                txtUsuario.Clear();
                txtPassword.Clear();

            }




        }
    }
}
