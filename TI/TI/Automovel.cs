using System;

namespace TI
{
	public class Automovel
	{
		private string placa;

		private string cor;

		private string marca;

		private string modelo;

		public Automovel ()
		{
		}

		public string _Modelo {
			get{return modelo; }
			set{ modelo = value; }
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

