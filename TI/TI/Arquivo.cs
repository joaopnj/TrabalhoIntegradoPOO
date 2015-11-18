using System;
using System.IO;

namespace TI
{
	public class Arquivo
	{
		Estacionamento estacionamento = new Estacionamento ();

        private string placa;

        private string tipoCarro;

        private string vezesEstacionado;

        private string dataEntrada;

        private string horaEntrada;

        private string dataSaida;

        private string horaSaida;

        private string tipoCliente;
        
        private string linha;

        private string id;

		private int b = 0;
		private static string nomeArquivo = "TI.txt";

		public string _Linha {
			get{return linha;}
			set{ linha = value; }
		}

		public string corpoDoArquivo(){
            foreach (Automovel item in estacionamento._Proprietario._Automoveis)
            {
                placa = item._Placa;
                tipoCarro = item._Tipo;
            }

            vezesEstacionado = estacionamento._Proprietario.VezesEstacionado.ToString();

            dataEntrada = estacionamento._TempoChegada.ToString().Substring(0, 9);

            horaEntrada = estacionamento._TempoChegada.ToString().Substring(10, 18);

            dataSaida = estacionamento.TempoSaida.ToString().Substring(0, 9);

            horaSaida = estacionamento.TempoSaida.ToString().Substring(10, 18);

            tipoCliente = estacionamento._Proprietario.Tipo;

            id = estacionamento._Id.ToString();

			 _Linha = placa+";"+ tipoCarro+ ";"+ vezesEstacionado+ ";" + dataEntrada+ ";" + horaEntrada + ";" + dataSaida+";"+horaSaida+";"+tipoCliente+";"+id+";";
			return _Linha;
		}

		// Gravar arquivo

		public void gravarArquivo(){
			
			if (!File.Exists (nomeArquivo)) {
				Stream saida = File.Open (nomeArquivo, FileMode.Create); // O FileMode cria o arquivo se o mesmo não existir,  
				StreamWriter escritor = new StreamWriter (saida);
				escritor.WriteLine (corpoDoArquivo ());
				escritor.Close ();
				saida.Close ();
			}
		}

		// Leitura de arquivo.

		public void leituraArquivo (string caminho)
		{
			if (File.Exists (caminho)) {

				Stream arquivos = File.Open (caminho, FileMode.Open);
				b = arquivos.ReadByte ();
				StreamReader leitor = new StreamReader (arquivos);
				string linhaLeitura = leitor.ReadLine ();
				while (linhaLeitura != null) {
					Console.WriteLine ((linhaLeitura));
					linhaLeitura = leitor.ReadLine ();
				}
				leitor.Close ();
				arquivos.Close ();

			} else {
				Console.WriteLine ("Arquivo não existente!!");
			}

		}
	}
}
