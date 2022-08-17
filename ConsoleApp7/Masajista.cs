using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Masajista: SeleccionFutbol
    {
		private String Titulacion;
		private int aniosExperiencia;

		public Masajista(int id, String nombre, String apellidos, int edad, String Titulacion, int aniosExperiencia) : base(id, nombre, apellidos, edad)
		{
			this.Titulacion = Titulacion;
			this.aniosExperiencia = aniosExperiencia;
		}

	public void darMasaje()
		{
			
		}
	}
}
