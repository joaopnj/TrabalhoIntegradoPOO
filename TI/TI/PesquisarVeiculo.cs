using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI
{
    public partial class PesquisarVeiculo : Form
    {
        public PesquisarVeiculo()
        {
            InitializeComponent();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarVeiculo pes = new CadastrarVeiculo();
            pes.Show();
            this.Close();
        }
    }
}
