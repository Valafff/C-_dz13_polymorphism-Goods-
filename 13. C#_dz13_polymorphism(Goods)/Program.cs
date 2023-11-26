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
			List<Goods> goods = new List<Goods> { };
			goods.Add(new Food("Хлеб ржаной", 30, 50, 300, DateTime.Now, DateTime.Now.AddDays(3)));
			goods.Add(new Food("Молоко", 85, 30, 100, DateTime.Now, DateTime.Now.AddDays(10)));
			goods.Add(new Food("Масло сливочное", 180, 100, 500, DateTime.Now, DateTime.Now.AddDays(60)));

			goods.Add(new Domestics("Мыло", 150, 200, "Моющее средство", DateTime.Now, DateTime.Now.AddDays(1095)));
			goods.Add(new Domestics("Пена для бритья", 350, 100, "Гигиена", new DateTime(2022, 12, 15), DateTime.Now.AddDays(1095)));
			goods.Add(new Domestics("Силит", 77, 60, "Чистящее средство", new DateTime(2023, 06, 10), DateTime.Now.AddDays(1095)));

			Menu market = new Menu(new List<string> { "Вывести все товары", "Вывести продукты питания", "Вывести бытовую химию", "Добавить продукты питания", "Добавить бытовую химию", "Продать товар", "Выход" });
			int index;
			//Временные позиции
			string tempName;
			string tempType;
			double tempPrice;
			int tempCount;
			int tempCalorie;
			int tempDayManufactureDate;
			int tempMonthManufactureDate;
			int tempYearManufactureDate;
			int tempExperationDate;
			int tempIndex;
			do
			{
				index = market.KlacKlac_CS_v1();
				Console.Clear();
				Console.CursorTop = 10;
				switch (index)
				{
					case 0:
						//Распечатка всех товаров
						foreach (Goods good in goods)
						{
							good.Print();
						}
						break;
					case 1:
						//Вывод продуктов питания
						foreach (Goods food in goods)
						{
							if (food is Food)
								food.Print();
						}
						break;
					case 2:
						//Вывод бытовой химии
						foreach (Goods domestic in goods)
						{
							if (domestic is Domestics)
								domestic.Print();
						}
						break;
					case 3:
						//ДОбавление продутов питания
						Console.Write("Введите название товара: ");
						tempName = Console.ReadLine();
						do
						{
							Console.Write("Введите цену: ");
							tempPrice = Convert.ToDouble(Console.ReadLine());
						}
						while (tempPrice < 0);
						do
						{
							Console.Write("Введите количество: ");
							tempCount = Convert.ToInt32(Console.ReadLine());
						}
						while (tempCount < 0);
						do
						{
							Console.Write("Введите калорийность: ");
							tempCalorie = Convert.ToInt32(Console.ReadLine());
						}
						while (tempCalorie < 0);
						do
						{
							Console.Write("Введите день изготовления: ");
							tempDayManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempDayManufactureDate <= 0 || tempDayManufactureDate > 31);
						do
						{
							Console.Write("Введите месяц изготовления: ");
							tempMonthManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempMonthManufactureDate <= 0 || tempMonthManufactureDate > 12);
						do
						{
							Console.Write("Введите год изготовления: ");
							tempYearManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempYearManufactureDate < 2020 || tempYearManufactureDate > DateTime.Now.Year);
						do
						{
							Console.Write("Введите срок годности(суток): ");
							tempExperationDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempExperationDate <= 0);
						goods.Add(new Food(tempName, tempPrice, tempCount, tempCalorie, new DateTime(tempYearManufactureDate, tempMonthManufactureDate, tempDayManufactureDate), new DateTime(tempYearManufactureDate, tempMonthManufactureDate, tempDayManufactureDate).AddDays(tempExperationDate)));
						break;
					case 4:
						//Добавление химии
						Console.Write("Введите название товара: ");
						tempName = Console.ReadLine();
						do
						{
							Console.Write("Введите цену: ");
							tempPrice = Convert.ToDouble(Console.ReadLine());
						}
						while (tempPrice < 0);
						do
						{
							Console.Write("Введите количество: ");
							tempCount = Convert.ToInt32(Console.ReadLine());
						}
						while (tempCount < 0);
						Console.Write("Введите тип: ");
						tempType = Console.ReadLine();
						do
						{
							Console.Write("Введите день изготовления: ");
							tempDayManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempDayManufactureDate <= 0 || tempDayManufactureDate > 31);
						do
						{
							Console.Write("Введите месяц изготовления: ");
							tempMonthManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempMonthManufactureDate <= 0 || tempMonthManufactureDate > 12);
						do
						{
							Console.Write("Введите год изготовления: ");
							tempYearManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempYearManufactureDate < 2020 || tempYearManufactureDate > DateTime.Now.Year);
						do
						{
							Console.Write("Введите срок годности(суток): ");
							tempExperationDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempExperationDate <= 0);
						goods.Add(new Domestics(tempName, tempPrice, tempCount, tempType, new DateTime(tempYearManufactureDate, tempMonthManufactureDate, tempDayManufactureDate), new DateTime(tempYearManufactureDate, tempMonthManufactureDate, tempDayManufactureDate).AddDays(tempExperationDate)));
						break;
					case 5:
						//Продажа товара
						bool is_sold = false;
                        Console.Write("Введите id товара: ");
						tempIndex = Convert.ToInt32 (Console.ReadLine());
						for (int i = 0; i < goods.Count(); i++)
						{
							if (goods[i].id == tempIndex)
							{
                                Console.Write("Введите количество продаваемого товара: ");
								tempCount = Convert.ToInt32(Console.ReadLine());
								if (goods[i].TotalCount != 0 & tempCount <= goods[i].TotalCount)
								{
									goods[i].SellGoods(tempCount);
									is_sold = true;
								}
								break;
							}
						}
						if (!is_sold)
						{
							Console.WriteLine("Ошибка! Товар не продан");
						}
						else
						{
							Console.WriteLine("Товар продан");
						}
						break;
					case 6:
						index = -1;
						break;
					default:
						break;
				}
			} while (index != -1);

		}
	}
}
