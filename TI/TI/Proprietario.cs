using System;
using System.Collections.Generic;

namespace TI
{
	public class Proprietario : Pessoa
	{
		private List<Automovel> veiculos;

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

		public Proprietario ()
		{
		}

		public List<Automovel> _Automoveis {
			get{ return veiculos; }
			set{ veiculos = value; }		
		}

		public void cadastrarAutomovel(){
           
		}
	}
}

