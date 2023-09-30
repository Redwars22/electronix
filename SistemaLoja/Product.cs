/*
 * Created by SharpDevelop.
 * User: leoan
 * Date: 29/09/2023
 * Time: 21:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Users;

namespace SistemaLoja
{
	/// <summary>
	/// Description of Product.
	/// </summary>
	public class Product
	{
		private string Name;
		private string ID;
		private string Brand;
		private double Price;
		private double Discount;
		
		const double JUROS = 0.6; 
		
		public string[] ProductIDs = {"9876-A", "4ZDF-0", "33PY-Q", "K12N-R", "VVVW-N"};
		public string[] Descriptions = {
			"Headphone Philips bluetooth on-ear, cor preto TAH1108BK/55",
			"Console PlayStation®5 Edição Digital",
			"Console Xbox Series X + Diablo IV",
			"Controle sem Fio Xbox - Stellar Shift",
			"Smartphone Redmi 12 4G 256GB - 8GB Ram (Versao Global) (Midnight Black) "
		};
		public string[] Brands = {"Phillips", "Sony", "Microsoft", "Microsoft", "Xiaomi"};
		public double[] Prices = {96.89, 3719.07, 4446.37, 559.00, 1889.99};
		
		public void UpdateProductInfo(int index)
		{
			this.Brand = this.Brands[index];
			this.Price = this.Prices[index];
			this.Name = this.Descriptions[index];
			this.ID = this.ProductIDs[index];
		}
		
		public bool FindProduct(string id)
		{
			for(var i = 0; i < ProductIDs.Length; i++)
			{
				if(ProductIDs[i] == id){
					this.UpdateProductInfo(i);
					return true;
				}
			}
			
			return false;
		}
		
		public void CalculatePrestacoes(int numPrestacoes)
		{
			if(numPrestacoes == 1)
			{
				Console.WriteLine("PAGAMENTO À VISTA");
				Console.Write("DESCONTO: R$ ");
				this.Discount = double.Parse(Console.ReadLine());
				
				Console.WriteLine("VALOR A PAGAR: R$ " + (this.Price - this.Discount));
			} else 
			{
				Console.Clear();
				
				Console.WriteLine("=#=#=#=#=#=[PARCELAMENTO EM " + numPrestacoes + " VEZES]=#=#=#=#=#=");
				
				this.Price = this.Price + ((this.Price * (JUROS * numPrestacoes)) / 100);
				
				for(var i = 2; i <= numPrestacoes; i++)
				{
					Console.WriteLine(i + "x R$ " + (this.Price / i).ToString("0.00"));
				}
			}
		}
		
		public void ToString()
		{
			Console.WriteLine("\nPRODUTO: " + this.Name);
			Console.WriteLine("CÓDIGO: " + this.ID);
			Console.WriteLine("PREÇO UNITÁRIO: R$" + this.Price);
			Console.WriteLine("MARCA: " + this.Brand);
		}
	}
}
