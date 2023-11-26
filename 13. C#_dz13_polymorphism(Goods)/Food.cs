using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.C__dz13_polymorphism_Goods_
{
	internal  class Food : Goods
	{
		public DateTime ManufactureDate { get; set; }
		public DateTime ExperationDate { get; set; }
		int calorie;
		public int Calorie
		{
			get { return calorie; }
			set
			{
				if(value< 0)
				{
					calorie = 0;
				}
				else 
				{
					calorie = value;
				}
			}
		}

		public Food(string arg_name, double arg_price, int arg_count, int arg_calorie, DateTime manufactureDate, DateTime experationDate) : base(arg_name, arg_price, arg_count)
		{
			calorie =arg_calorie;
			ManufactureDate = manufactureDate;
			ExperationDate = experationDate;
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
		public virtual void AddExpData(DateTime arg_date)
		{
			ExperationDate = arg_date;
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
            Console.WriteLine($"Артикул: {id} Название товара: {Name} Цена товара: {Price} руб. Кол-во на складе: {TotalCount} шт.\nПищевая ценность: {calorie} ккал. Дата изготовления: {ManufactureDate.ToShortDateString()} Срок годности до: {ExperationDate.ToShortDateString()}");
        }

		//public virtual void DeleteGoods(int arg_count);

	}
}
