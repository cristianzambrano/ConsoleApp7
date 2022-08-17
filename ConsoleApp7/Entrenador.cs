using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Entrenador: SeleccionFutbol
    {
		private String idFederacion;

		public Entrenador(int id, String nombre, String apellidos, int edad, String idFederacion) : base(id, nombre, apellidos, edad)
		{
			this.idFederacion = idFederacion;
		}

		// getter y setter

		public void dirigirPartido()
		{
		
		}

		public void dirigirEntreno()
		{
			
		}
	}
}
