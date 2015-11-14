using System;

namespace TI
{
	public class Automovel
	{
		private string placa;

		private string cor;

		private string marca;

		private string nome;

		public Automovel ()
		{
		}

		public string _Nome {
			get{return nome; }
			set{ nome = value; }
		}

		public string _Cor{
			get{return cor; }
			set{ cor = value; }
		}

		public string _Marca{
			get{return marca; }
			set{ marca = value; }
		}

		public string _Placa{
			get{return placa; }
			set{ placa = value; }
		}
	}
}

