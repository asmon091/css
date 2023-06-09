
using System;
using System.IO;
namespace Persistencia1
{
	public class ArchVehiculo
	{
		private string na;
		private Vehivulo rVehi;
		public ArchVehiculo(string nam)
		{
			this.na=nam;
		}
		public void crear(){
			if(File.Exists(na))
				File.Delete(na);
		}
		
		public void adicionar(){
			int num;
			int m=0;
			Console.WriteLine("n vehículos");
			num = int.Parse(Console.ReadLine());
			Stream aVehi = File.Open(na, FileMode.OpenOrCreate);
			BinaryWriter escribe = new BinaryWriter(aVehi);
			Console.WriteLine("----- ADICIONAR ------\n");
			try{
				while (m<num) {
					m=m+1;
					rVehi = new Vehivulo();
					rVehi.leer();
					escribe.Seek(0,SeekOrigin.End);
					rVehi.escritor(escribe);
					Console.WriteLine("-----------------");
				}
			}
			catch(Exception){
				Console.WriteLine("Fin adicion");
			}
			finally{
				aVehi.Close();
			}
		}
		
		public void listar(){
			Stream aVehiculo = File.Open(na, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(aVehiculo);
			Console.WriteLine("----- LISTAR ------\n");
			try {
				while (true) {
					rVehi = new Vehivulo();
					rVehi.lector(lee);
					rVehi.mostrar();
				}
			} catch (Exception) {
				Console.WriteLine("fin listado!!");
			} finally {
				aVehiculo.Close();
			}
		}
		
		public void numPlacaImpar(){
			Stream aVehiculo = File.Open(na, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(aVehiculo);
			Console.WriteLine("----- Numero de placa impar ------\n");
			
			try {
				while (true) {
					rVehi=new Vehivulo();
					rVehi.lector(lee);
					int x = int.Parse(rVehi.Placa);
					if (x%2 != 0) {
						rVehi.mostrar();
					}
					
				}
			} catch (Exception) {
				Console.WriteLine("fin listado!!");
			} finally {
				aVehiculo.Close();
			}
		}
		
		public void vehiculoModelo(string x){
			Stream aVehiculo = File.Open(na, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(aVehiculo);
			Console.WriteLine("----- Vehiculo de modelo x ------\n");
			try{
				while (true) {
					rVehi=new Vehivulo();
					rVehi.lector(lee);
					if (rVehi.Modelo==x) {
						rVehi.mostrar();
					}
				}
			} catch (Exception) {
				Console.WriteLine("fin listado!!");
			} finally {
				aVehiculo.Close();
			}
		}
	}
}
