using System;

namespace TI
{
	public class Automovel
	{
		private string placa;

		private string cor;

		private string nome;

		private string tipo;

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

		public string _Nome{
			get{return nome; }
			set{ nome = value; }
		}

		public string _Placa{
			get{return placa; }
			set{ placa = value; }
		}

		public string _Tipo {
			get{ return tipo; }
			set{ tipo = value; }
		}
	}
}

