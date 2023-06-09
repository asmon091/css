
using System;

namespace Persistencia1
{
	public class Principal
	{
		public static void Main()
		{
			ArchVehiculo ve1 = new ArchVehiculo("Vehiculo.dat");
			Console.ForegroundColor = ConsoleColor.Black;
           Console.BackgroundColor = ConsoleColor.White;
			int aux;
			do{
				Console.WriteLine("\nARCHIVO VEHICULO");
				Console.WriteLine("1. crear\n" +
				                  "2. Adicionar\n" +
				                  "3. Listar\n" +
				                  "4. num impar placa\n" +
				                  "5. modelo x" +
				                  "6. finalizar");
				aux=int.Parse(Console.ReadLine());
				switch (aux) {
						case 1: ve1.crear();
						break;
						case 2: ve1.adicionar();
						break;
						case 3: ve1.listar();
						break;
						case 4: ve1.numPlacaImpar();
						break;
						case 5: ve1.vehiculoModelo("nissan");
						break;
						case 6: Console.WriteLine("FIN");
						break;
				}
			}while(aux !=6);	
			Console.ReadKey();
		}
	}
}
