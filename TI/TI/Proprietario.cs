using System;
using System.Collections.Generic;

namespace TI
{
	public class Proprietario : Pessoa
	{
		private List<Veiculo> veiculos;

		public Proprietario ()
		{
		}

		public List<Veiculo> _Automoveis {
			get{ return veiculos; }
			set{ veiculos = value; }
		
		}

		public void cadastrarAutomovel(){
			// Método intera adiciona um ou mais veiculos ao proprietário.
		}
	}
}

