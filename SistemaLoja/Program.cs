/*
 * Created by SharpDevelop.
 * User: leoan
 * Date: 28/09/2023
 * Time: 15:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Users;

namespace SistemaLoja
{
	class Program
	{
		public static void ShowHeader(string user, string timeStamp)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			
			Console.WriteLine("=#=#=#=#=[ BEM-VINDO À ELECTRONIX ]=#=#=#=#=");
			
			Console.ForegroundColor = ConsoleColor.Blue;
			
			Console.WriteLine("BEM-VINDO, " + user.ToUpper());
			Console.WriteLine("LOGADO ÀS " + timeStamp);
			
			Console.ForegroundColor = ConsoleColor.Red;
			
			for(var i = 0; i < 10; i++){
				Console.Write("=#=");
			}
			
			Console.ForegroundColor = ConsoleColor.White;
		}
		
		public static void Main(string[] args)
		{
			var user = new User();
			
			string timeStamp = DateTime.Now.ToString("hh:mm:ss tt - yyyy-MM-dd");
			
			Console.WriteLine("=#=#=#=#=[ BEM-VINDO À ELECTRONIX ]=#=#=#=#=");
			Console.WriteLine("AGORA SÃO " + timeStamp);
			
			for(var i = 0; i < 10; i++){
				Console.Write("=#=");
			}
			
			while(user.GetIsLogged() != true){
				user.LogIn();
			}

			while(true)
			{
				Console.Clear();
			
				ShowHeader(user.GetName(), timeStamp);
			
				Console.Write("\nINSIRA O CÓDIGO DO PRODUTO: ");
				var code = Console.ReadLine();
				var product = new Product();
				
				if(product.FindProduct(code)){
					product.ToString();
					Console.Write("DIGITE A QUANTIDADE DE PRESTAÇÕES (DE 1 A 24 - A PRAZO JUROS (0.6 * PRESTAÇÕES)%): ");
					var prestacoes = int.Parse(Console.ReadLine());
					
					if(prestacoes > 0 && prestacoes <= 24)
						product.CalculatePrestacoes(prestacoes);
					
					Console.Write("PRESSIONE UMA TECLA PARA CONTINUAR...");
					Console.ReadKey();
				} else {
					Console.WriteLine("[!!!] - PRODUTO NÃO ENCONTRADO. CÓDIGO INVÁLIDO OU INDISPONÍVEL NO ESTOQUE.");
				}
				
				/*if()
				{}*/
			}
		}
	}
}