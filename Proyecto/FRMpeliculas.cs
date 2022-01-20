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
    public partial class FRMpeliculas : Form
    {
        FRMlogin login;
        Sistema S = Program.getSistema();
        public string usuario;
        int totalpelis;
        public FRMpeliculas(FRMlogin L, string user)
        {
            InitializeComponent();
            login = L;
            usuario = user;
            Texto1.Hide();
            CrearDWV();
        }

        private void BTNatras_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();   
        }

        private void BTNcomentar_Click(object sender, EventArgs e)
        {
            new FRMcomentarios(DWVcatalogo.CurrentRow.Index).Show();
        }

        private void FRMusuario_FormClosed(object sender, FormClosedEventArgs e)
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

    }
}
