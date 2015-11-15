using System;

namespace TI
{
		public class ExcecaoGenerica : Exception
		{
			public string  erroGenerico{get;set;}

			public ExcecaoGenerica() { }

			public ExcecaoGenerica(string aErroGenerico)
			{
				this.erroGenerico = erroGenerico+" "+aErroGenerico;
			}

			public override string ToString()
			{
				return erroGenerico;
			}
		}
}


