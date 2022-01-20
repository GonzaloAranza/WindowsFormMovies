using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FRMadmin : Form
    {
        FRMlogin login;
        private Sistema S = Program.getSistema();
        int totalpelis;

        public FRMadmin(FRMlogin login)
        {
            this.login = login;
            InitializeComponent();
            CrearDWV();

        }

        private void BTNvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void BTNagregar_Click(object sender, EventArgs e)
        {
            string clasificacion = "";
            if (!validarTextBox())
            {
                MessageBox.Show("complete todos los campos");
                return;
            }

            if (ATP.Checked)
                clasificacion = "ATP";
            if (pre.Checked)
                clasificacion = "+13";
            if (ado.Checked)
                clasificacion = "+16";
            if (adu.Checked)
                clasificacion = "+18";

            if (!S.ChequeoPeliculas(nombre.Text, fecha.Text, director.Text, genero.Text, clasificacion, sinopsis.Text))
            {
                MessageBox.Show("película ya ingresada");
            }
            else
            {
                int n = DWVcatalogo.Rows.Add();
                DWVcatalogo.Rows[n].Cells[0].Value = nombre.Text;
                DWVcatalogo.Rows[n].Cells[1].Value = fecha.Text;
                DWVcatalogo.Rows[n].Cells[2].Value = director.Text;
                DWVcatalogo.Rows[n].Cells[3].Value = genero.Text;
                DWVcatalogo.Rows[n].Cells[4].Value = clasificacion;

                nombre.Text = "";
                fecha.Text = "";
                director.Text = "";
                genero.Text = "";
                ATP.Checked = true;
            }
        }

        private void BTNborrar_Click(object sender, EventArgs e)
        {
            int n = (DWVcatalogo.CurrentRow.Index);
            if (MessageBox.Show("¿desea borrar la pelicula? " +
                                 DWVcatalogo.Rows[n].Cells[0].Value, "Ejemplos",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning)
                                 == DialogResult.Yes)
            {
                S.BorrarPeli(n);
                DWVcatalogo.Rows.RemoveAt(n);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DWVcatalogo.CurrentRow.Index.ToString());
        }

        private void FRMadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Close();
        }

        public void CrearDWV()
        {
            string[] datospelis = new string[DWVcatalogo.ColumnCount];
            totalpelis = S.Totalpeliculas(totalpelis);


            for (int i = 0; i < totalpelis; i++)
            {

                DWVcatalogo.Rows.Add();
                datospelis = S.DatosPelis(datospelis, i);
                for (int j = 0; j < DWVcatalogo.ColumnCount; j++)
                {
                    DWVcatalogo.Rows[i].Cells[j].Value = datospelis[j];
                }

            }
            DWVcatalogo.AllowUserToAddRows = false;
        }

        private bool validarTextBox()
        {
            foreach (Control Controls in this.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (Controls is TextBox & Controls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    return false; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            return true;
        }

    }
}
