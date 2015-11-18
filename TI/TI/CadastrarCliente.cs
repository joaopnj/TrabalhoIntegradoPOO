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
    public partial class CadastrarCliente : Form
    {
        private static string CAMINHO = "ARQUIVO.txt";

        private Proprietario prop = new Proprietario();

        private Arquivo arq;

        private List<Automovel> listaAuto;

        public CadastrarCliente()
        {
            InitializeComponent();
        }

        public List<Automovel> _ListaAuto
        {
            get { return listaAuto; }
            set { listaAuto = value; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            CadastrarVeiculo cadVeic = new CadastrarVeiculo();
            cadVeic.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            prop._Nome = txtNome.Text;
            prop._CPF = txtCPF.Text;
            prop.Tipo = cbTipoCliente.SelectedText;

            arq.leituraArquivo(CAMINHO);
            arq.gravarArquivo();

        }
    }
}
