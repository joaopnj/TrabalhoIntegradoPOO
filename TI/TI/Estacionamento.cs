using System;

namespace TI
{
	public class Estacionamento
	{
        private int id;

        public int _Id
        {
            get { return id; }
            set { id = value; }
        }

		private int vagas;

		private int numeroVaga;

		private int valorHora;

		private Proprietario proprietario;

		private double tempoEstacionado;

		private DateTime tempoChegada;

        private DateTime tempoSaida;

        public DateTime TempoSaida
        {
            get { return tempoSaida; }
            set { tempoSaida = value; }
        }

		public Estacionamento ()
		{
		}

		public int _Vagas {
			get{ return vagas; }
			set{ vagas = value; }
		}

		public int _NumVaga {
			get{ return numeroVaga; }
			set{ numeroVaga = value; }
		}

		public int _ValorHora {
			get{ return valorHora; }
			set{ valorHora = value; }
		}

		public Proprietario _Proprietario{
			get{ return proprietario; }
			set{ proprietario = value; }
		}

		public double _TempoEstacionado{
			get{ return tempoEstacionado; }
			set{ tempoEstacionado = value; }
		}

		public DateTime _TempoChegada{
			get{ return tempoChegada; }
			set{ tempoChegada = value; }
		}

		public double valorPagar(){
			// Método para calcular o valor a pagar pelo cliente.
			return 0;
		}

		public void gerarExtrato(){
			// Método para mostrar detalhes da permanencia justificando valor pago pelo cliente.
		}

		public double faturamento(){
			// Método para calculo de faturamento.
			return 0;
		}
	}
}

