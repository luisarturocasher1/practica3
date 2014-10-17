/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 17/10/2014
 * Time: 05:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace practica3
{
	class practica3
	{
		public string nombre, codigo,indice;
		public int opc;
		public static void Main (string[] args)
		{

			practica3 pra = new practica3 ();

			Hashtable tabla = new Hashtable ();



			do {
				Console.WriteLine("ingrese codigo");
				pra.codigo = Console.ReadLine();
				Console.WriteLine("ingrese nombre");
				pra.nombre = Console.ReadLine();
				tabla.Add(pra.codigo,pra.nombre);

				Console.WriteLine("1 introdusca mas valores");
				Console.WriteLine("2 edite valores");
				Console.WriteLine("3 ver valores");
				Console.WriteLine("4 borrar valores");
				Console.WriteLine("5 salir");
				pra.opc =int.Parse (Console.ReadLine());
				switch(pra.opc)
				{
				case 1:
					break;
				case 2:
					Console.WriteLine("escriba codigo a editar");
					pra.indice=Console.ReadLine();
					tabla.Remove(pra.indice);

					Console.WriteLine("escriba nuevo codigo");
					pra.codigo = Console.ReadLine();
					Console.WriteLine("escriba nombre");
					pra.nombre = Console.ReadLine();
					tabla.Add(pra.codigo,pra.nombre);

					break;
				case 3:

					Console.WriteLine("escriba codigo");
					pra.indice=Console.ReadLine();
					object valor = tabla [pra.indice];
					Console.WriteLine ("el nombre es : "+valor);


					break;
				case 4:
					Console.WriteLine("escriba codigo a remover");
					pra.indice=Console.ReadLine();
					tabla.Remove(pra.indice);


					break;






				}









			}while (pra.opc!=5);

		}
	}
}