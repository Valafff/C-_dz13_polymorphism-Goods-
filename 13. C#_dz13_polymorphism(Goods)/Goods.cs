using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _13.C__dz13_polymorphism_Goods_
{
	internal abstract class Goods
	{
		static uint ID;
		public uint id { get; }
		public string Name { get; set; }

		//public double Price { get; set; }
		double price;

		public double Price
		{
			get { return price; }
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				price = value;
			}
		}

		//public bool Is_sold { get; set; }
		public int TotalCount { get; set; }

		public Goods(string arg_name, double arg_price, int count = 1)
		{
			id = ID;
			ID++;
			Name = arg_name;
			Price = arg_price;
			//Is_sold = arg_status;
			if (count > 0)
			{
				TotalCount = count;
			}
			else
			TotalCount = 1;
		}

		public abstract void ReName(string arg_name);
		public abstract void RePrice(double arg_price);
		public abstract void AddGoods(int arg_status);
		public abstract void Print();
		public abstract void SellGoods(int arg_count);
	}


}
