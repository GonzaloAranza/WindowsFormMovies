using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class FRMcreate : Form
    {
      
        private Form login;
        private Sistema S = Program.getSistema();
        public FRMcreate(Form inicio)
        {
            this.login = inicio;
            InitializeComponent();
        }
          

        //crear usuarios 
        private void BTNcrear_Click(object sender, EventArgs e)
        {

            if (!S.Chequeo(usuario.Text, contraseña.Text))
            {
                MessageBox.Show("usuario existente");
                return;
            }
            else
            {
                MessageBox.Show("usuario creado con exito:" + "\n" + usuario.Text + '\n' + contraseña.Text);
                usuario.Text = "";
                contraseña.Text = "";                
            }
            

        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FRMcreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

 
    }
}
