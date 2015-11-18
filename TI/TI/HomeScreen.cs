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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnGerenciarEstacionamento_Click(object sender, EventArgs e)
        {
            GerenciarEstacionamento mngPark = new GerenciarEstacionamento();
            mngPark.Show();            
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cliente = new CadastrarCliente();
            cliente.Show();
        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            PesquisarVeiculo cadVeic = new PesquisarVeiculo();
            cadVeic.Show();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            GerarHistorico historico = new GerarHistorico();
            historico.Show();
        }
    }
}
