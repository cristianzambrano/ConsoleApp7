using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	public class Futbolista : SeleccionFutbol
	{
	private int dorsal;
	private String demarcacion;

	public Futbolista(int id, String nombre, String apellidos, int edad, int dorsal, String demarcacion): base(id, nombre, apellidos, edad)
	{
			this.dorsal = dorsal;
			this.demarcacion = demarcacion;
	}

	public Futbolista(): base()
	{
		
	}

	public void jugarPartido()
	{

	}

	public void entrenar()
	{

	}

}
}
