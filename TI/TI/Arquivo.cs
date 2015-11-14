using System;
using System.IO;

namespace TI
{
	public class Arquivo
	{
		Estacionamento estacionamento = new Estacionamento ();

		private string linha;

		private int b = 0;

		private static string nomeArquivo = "TI.txt";

		public string _Linha {
			get{return linha;}
			set{ linha = value; }
		}

		private string corpoDoArquivo(){
			_Linha = estacionamento._Proprietario._Nome +" ; "+ estacionamento._Proprietario._Automoveis + " ; "
				+ estacionamento._Proprietario._CPF + " ; " + estacionamento._TempoChegada + " ; " + estacionamento._TempoEstacionado + " ; " + estacionamento._NumVaga+" ; "+ estacionamento.valorPagar().ToString();
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

		public void leituraArquivo ()
		{
			if (File.Exists (nomeArquivo)) {

				Stream arquivos = File.Open (nomeArquivo, FileMode.Open);
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
