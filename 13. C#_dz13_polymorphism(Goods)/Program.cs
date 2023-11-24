using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.C__dz13_polymorphism_Goods_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Bread bread_1 = new Bread("Хлеб", 30.5, 10, DateTime.Now, new DateTime(2023,11,25), "Ржаной");
			bread_1.Print();
			bread_1.AddGoods(10);
			bread_1.Print();
			bread_1.SellGoods(2);
			bread_1.Print();
			Car car_1 = new Car ("Машина", 10000000, 10, DateTime.Now, new DateTime(2025,11,30), "Порше Кайен");
			car_1.SellGoods();
			car_1.Print();

		}
	}
}
