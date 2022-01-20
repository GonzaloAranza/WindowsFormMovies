using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Proyecto
{
    public partial class FRMlogin : Form
    {
        private FRMcreate FRMcrearcuenta;
        private FRMadmin FRMadministracion;
        private FRMpeliculas FRMusuario;
        private Sistema S = Program.getSistema();
        public FRMlogin()
        {          
            InitializeComponent();
        }

        private void BTNacceder_Click(object sender, EventArgs e)
        {

            if (S.EsAdmin(usuario.Text, contraseña.Text))
            {
                FRMadministracion = new FRMadmin(this);
                FRMadministracion.Show();
                this.Hide();
                return;
            }

            if(S.EsUsuario(usuario.Text, contraseña.Text))
            {
                this.Hide();
                FRMusuario = new FRMpeliculas(this, usuario.Text);
                FRMusuario.Show();
            }
            else
                MessageBox.Show("datos incorrectos");
        }
        private void BTNcrear_Click(object sender, EventArgs e)

        {
            usuario.Text = "";
            contraseña.Text = "";
            this.Hide();
            FRMcrearcuenta = new FRMcreate(this);
            FRMcrearcuenta.Show();
        }

        

    }
}
