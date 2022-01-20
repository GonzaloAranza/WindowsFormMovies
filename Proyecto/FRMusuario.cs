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
    public partial class FRMusuario : Form
    {
        FRMlogin retorno;
        Sistema S = Program.getSistema();
        int totalpelis;
        Movie PeliSeleccionada;
        public FRMusuario(FRMlogin L)
        {
            InitializeComponent();
            retorno = L;

            string[] datospelis = new string[DWTcatalogo.ColumnCount];
            totalpelis = S.Totalpeliculas(totalpelis);


            for (int i = 0; i < totalpelis; i++)
            {

                DWTcatalogo.Rows.Add();
                datospelis = S.DatosPelis(datospelis, i);
                for (int j = 0; j < DWTcatalogo.ColumnCount; j++)
                {
                    DWTcatalogo.Rows[i].Cells[j].Value = datospelis[j];
                }

            }
            DWTcatalogo.AllowUserToAddRows = false;
        }

        private void FRMusuario_Load(object sender, EventArgs e)
        {

        }

        private void BTNatras_Click(object sender, EventArgs e)
        {
            retorno.Show();
            this.Close();
            
        }



        private void DTWcatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNcomentar_Click(object sender, EventArgs e)
        {
            new FRMcomentarios(DWTcatalogo.CurrentRow.Index).Show();
        }
    }
}
