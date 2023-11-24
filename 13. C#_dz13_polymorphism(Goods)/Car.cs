using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.C__dz13_polymorphism_Goods_
{
	internal class Car : Domestics
	{

		public string MarkOfCar { get; set; }

		public Car(string arg_name, double arg_price, int arg_count, DateTime manufactureDate, DateTime experationDate, string arg_typeOf) : base(arg_name, arg_price, arg_count, manufactureDate, experationDate)
		{
			MarkOfCar = arg_typeOf;
		}

		public override void ReName(string arg_name)
		{
			Name = arg_name;
		}
		public override void RePrice(double arg_price)
		{
			if (arg_price >= 0)
			{
				Price = arg_price;
			}
		}
		public override void AddGoods(int arg_count)
		{
			TotalCount += arg_count;
		}
		public override void AddManData(DateTime arg_date)
		{
			ManufactureDate = arg_date;
		}
		public override void AddGarrantyData(DateTime arg_date)
		{
			GarrantyEndDate = arg_date;
		}
		public override void SellGoods(int arg_count = 1)
		{
			if (arg_count <= TotalCount)
			{
				TotalCount -= arg_count;
			}
			else
			{
				Console.WriteLine("Количество товара на складе меньше продаваемого количества");
			}

		}

		public override void Print()
		{
			Console.WriteLine($"Название товара {Name} Марка машины {MarkOfCar} Цена товара {Price} Количество на складе {TotalCount} Дата изготовления {ManufactureDate} Окончание гарантии {GarrantyEndDate}");
		}
	}
	}
