using System;

namespace TI
{
	public class Veiculo : Automovel 
	{
		private string tipo;

		public Veiculo ()
		{
		}

		public string _Tipo {
			get{ return tipo; }
			set{ tipo = value; }
		}

	}
}

