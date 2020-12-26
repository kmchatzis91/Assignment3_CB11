using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirt
{
	class Program
	{
		static void Main(string[] args)
		{
			var tshirt = new TShirt(Color.Green, Size.L, Fabric.Cashmere);
			var shirtCost = new TShirtCost(tshirt, new CreditCard());

			Console.WriteLine("Green Large Cashmere Shirt paid with Credit Card costs:");
			Console.WriteLine(shirtCost.ShirtCost());

			shirtCost.SetPayment(new BankTransfer());
			Console.WriteLine("Green Large Cashmere Shirt paid with Bank Transfer costs:");
			Console.WriteLine(shirtCost.ShirtCost());

			shirtCost.SetPayment(new Cash());
			Console.WriteLine("Green Large Cashmere Shirt paid with Cash costs:");
			Console.WriteLine(shirtCost.ShirtCost());

			Console.WriteLine();

			var tshirtRed = new TShirt(Color.Red, Size.XXL, Fabric.Rayon);
			shirtCost = new TShirtCost(tshirtRed, new CreditCard());

			Console.WriteLine("Red XXL Rayon Shirt paid with Credit Card costs:");
			Console.WriteLine(shirtCost.ShirtCost());

			shirtCost.SetPayment(new BankTransfer());
			Console.WriteLine("Red XXL Rayon Shirt paid with Bank Transfer costs:");
			Console.WriteLine(shirtCost.ShirtCost());

			shirtCost.SetPayment(new Cash());
			Console.WriteLine("Red XXL Rayon Shirt paid with Cash costs:");
			Console.WriteLine(shirtCost.ShirtCost());

		}
	}
}
