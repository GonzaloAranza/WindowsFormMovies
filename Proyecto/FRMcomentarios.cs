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
    public partial class FRMcomentarios : Form
    {
        private Sistema S = Program.getSistema();
        private int NumPeli;
        public FRMcomentarios(int n)
        {
            InitializeComponent();
            NumPeli = n;
        }

        private void FRMcomentarios_Load(object sender, EventArgs e)
        {
         
        }

        private void BTNcomentar_Click(object sender, EventArgs e)
        {
           
        }

        private void FRMcomentarios_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
