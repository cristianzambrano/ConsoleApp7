using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	internal class Program
	{
		public static List<SeleccionFutbol> integrantes = new List<SeleccionFutbol>();

		static void Main(string[] args)
		{

			Entrenador delBosque = new Entrenador(1, "Vicente", "Del Bosque", 60, "284EZ89");
			Futbolista iniesta = new Futbolista(2, "Andres", "Iniesta", 29, 6, "Interior Derecho");
			Masajista raulMartinez = new Masajista(3, "Raúl", "Martinez", 41, "Licenciado en Fisioterapia", 18);

			integrantes.Add(delBosque);
			integrantes.Add(iniesta);
			integrantes.Add(raulMartinez);

			// CONCENTRACION
			Console.WriteLine("Todos los integrantes comienzan una concentracion. (Todos ejecutan el mismo método)");
			foreach (SeleccionFutbol integrante in integrantes)
			{
				Console.Write(integrante.getNombre() + " " + integrante.getApellido() + " -> ");
				integrante.Concentrarse();
			}

			// VIAJE
			Console.WriteLine("nTodos los integrantes viajan para jugar un partido. (Todos ejecutan el mismo método)");
			foreach (SeleccionFutbol integrante in integrantes)
			{
				Console.Write(integrante.getNombre() + " " + integrante.getApellido() + " -> ");
				integrante.Viajar();
			}

			Console.ReadLine();

		}
	}

	

	



}
