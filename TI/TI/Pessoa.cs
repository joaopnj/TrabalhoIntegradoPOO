using System;

namespace TI
{
	public abstract class Pessoa
	{
		private string nome;

		private string cpf;

		public Pessoa ()
		{
		}

		public string _Nome {
			get{return nome; }
			set{ nome = value; }
		}

		public string _CPF {
			get{return cpf; }
			set{ cpf = value; }
		}
	}
}

