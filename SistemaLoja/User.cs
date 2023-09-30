/*
 * Created by SharpDevelop.
 * User: leoan
 * Date: 29/09/2023
 * Time: 21:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Users
{
	/// <summary>
	/// Description of User.
	/// </summary>
	public class User
	{
		private string Name;
		private string Login;
		private string Password;
		private bool IsLogged;
		
		public User()
		{
			this.SetName("Ezekiel Gabriel dos Santos Torres");
		}
		
		public void LogIn()
		{
			Console.Write("\nLOGIN: ");
			this.Login = Console.ReadLine();
			Console.Write("SENHA: ");
			this.Password = Console.ReadLine();
			
			if(this.IsPasswordValid(this.Login, this.Password))
			{
				this.IsLogged = true;
			}
		}
		
		public string GetName()
		{
			return this.Name;
		}
		
		public void SetName(string name)
		{
			this.Name = name;
		}
		
		public bool GetIsLogged()
		{
			return this.IsLogged;
		}
		
		private bool IsPasswordValid(string login, string password)
		{
			const string _DEFAULTUSERLOGIN = "ve1723";
			const string _DEFAULTUSERPWD = "123456";
			
			if(login == _DEFAULTUSERLOGIN && password == _DEFAULTUSERPWD)
			{
				return true;
			} else {
				Console.WriteLine("\n[!!!] - SENHA OU LOGIN INCORRETOS. TENTE NOVAMENTE!");
				return false;
			}
		}
		
	}
}
