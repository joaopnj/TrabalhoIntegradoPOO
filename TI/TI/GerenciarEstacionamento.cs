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
    public partial class GerenciarEstacionamento : Form
    {
        public GerenciarEstacionamento()
        {
            InitializeComponent();
        }

        Estacionamento barroPreto = new Estacionamento();
        Estacionamento vendaNova = new Estacionamento();
        Estacionamento centro = new Estacionamento();

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cadastraEstacionamento()
        {
            barroPreto._Id = 0;
            barroPreto._Vagas = 10;
            barroPreto._ValorHora = 9;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void GerenciarEstacionamento_Load(object sender, EventArgs e)
        {
            


        }
        

        private DateTime getTime() 
        {
            return DateTime.Now;
        }
        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 