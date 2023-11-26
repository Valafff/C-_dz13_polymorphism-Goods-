using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.C__dz13_polymorphism_Goods_
{
	internal class Domestics : Goods
	{

		public DateTime ManufactureDate { get; set; }
		public DateTime GarrantyEndDate { get; set; }
		public string Type { get; set; }
		public Domestics(string arg_name, double arg_price, int arg_count, string arg_type, DateTime manufactureDate, DateTime arg_GarrantyEndDate) : base(arg_name, arg_price, arg_count)
		{
			Type = arg_type;
			ManufactureDate = manufactureDate;
			GarrantyEndDate = arg_GarrantyEndDate;
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
		public virtual void AddManData(DateTime arg_date)
		{
			ManufactureDate = arg_date;
		}
		public virtual void AddGarrantyData(DateTime arg_date)
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
			Console.WriteLine($"Артикул: {id} Название товара: {Name} Тип товара: {Type} Цена товара: {Price} руб. Кол-во на складе: {TotalCount} шт. \nДата изг.: {ManufactureDate.ToShortDateString()}  Срок годности до: {GarrantyEndDate.ToShortDateString()}");
		}

	}
}
