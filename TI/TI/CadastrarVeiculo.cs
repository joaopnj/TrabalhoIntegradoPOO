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
    public partial class CadastrarVeiculo : Form
    {
        private List<Automovel> listaAuto;

        public CadastrarVeiculo()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Automovel item in listaAuto)
            {
                item._Modelo =  txtModelo.Text ;
                item._Nome = txtNome.Text;
                item._Cor = txtCor.Text;
                item._Tipo = cbTipoVeiculo.SelectedItem.ToString();
                item._Placa = txtPlaca.Text;
            }
            CadastrarCliente c = new CadastrarCliente();
            c._ListaAuto = listaAuto;
            c.Show();
            this.Close();
        }

        private void cbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
