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
		static public uint ID;
		public string Name { get; set; }
		public double Price { get; set; }


		//public double Price
		//{
		//	get { return Price; }
		//	set
		//	{
		//		if (value < 0)
		//		{
		//			value = 0;
		//		}
		//		price = value;
		//	}
		//}

		//public bool Is_sold { get; set; }
		public int TotalCount { get; set; }

		public Goods(string arg_name, double arg_price, int count = 1)
		{
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
		//public abstract void DeleteGoods(int arg_count);


		//~Goods()
		//{
		//	ID--;
		//}
	}


}
