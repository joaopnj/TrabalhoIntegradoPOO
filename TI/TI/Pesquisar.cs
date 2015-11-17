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
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private static string caminho = "ARQUIVO.txt";

        private List<Proprietario> prop;

        private Proprietario proprietario;

        private void obterListaClientes (){
            Arquivo arq = new Arquivo();
            arq.leituraArquivo(caminho);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obterListaClientes();
            
            foreach (Proprietario item in prop)
            {
                if (item..Equals(proprietario._CPF)) { 
                }
            }
            
        }
    }
}
