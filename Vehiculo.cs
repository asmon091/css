
using System;
using System.IO;
namespace Persistencia1
{
	public class Vehivulo
	{
		private string placa;
		private string marca;
		private string modelo;
		private double kilometraje;
		public void leer(){
			Console.WriteLine("placa--marca--modelo--kilometraje");
			this.placa= Console.ReadLine();
			this.marca= Console.ReadLine();
			this.modelo= Console.ReadLine();
			this.kilometraje=double.Parse(Console.ReadLine());
		}
		public void mostrar(){
			Console.WriteLine(placa+" - "+marca+" - "+modelo+" - "+kilometraje);
		}
		public void escritor(BinaryWriter j){
			j.Write(placa);
			j.Write(marca);
			j.Write(modelo);
			j.Write(kilometraje);
		}
		public void lector(BinaryReader j){
			placa=j.ReadString();
			marca=j.ReadString();
			modelo=j.ReadString();
			kilometraje=j.ReadDouble();
		}
		public string Placa {
			get { return placa; }
			set { placa = value; }
		}
		public string Marca {
			get { return marca; }
			set { marca = value; }
		}
		public string Modelo {
			get { return modelo; }
			set { modelo = value; }
		}		
		public double Kilometraje {
			get { return kilometraje; }
			set { kilometraje = value; }
		}
	}
}
