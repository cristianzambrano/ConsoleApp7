using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	public class SeleccionFutbol
	{

		protected int id;
		protected String Nombre;
		protected String Apellidos;
		protected int Edad;

		// constructor, getter y setter

		public String getNombre()
        {
			return Nombre;
        }

		public String getApellido()
		{
			return Apellidos;
		}


		public SeleccionFutbol()
		{
		}

		public SeleccionFutbol(int id, String nombre, String apellidos, int edad)
		{
			this.id = id;
			this.Nombre = nombre;
			this.Apellidos = apellidos;
			this.Edad = edad;
		}

		public void Concentrarse()
		{
			Console.WriteLine("Concentrase");

		}

		public void Viajar()
		{
			Console.WriteLine("Viajar");
		}
	}
}
