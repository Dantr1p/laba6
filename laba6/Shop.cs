using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
	class Shop
	{
		//Поля объекта		
		const int N = 30;
		private string name;
		private int n;
		private double cash = 0;
		private Laptop[] laptop = new Laptop[N];
		//Методы объекта		
		public Shop()
		{
			this.name = "Обычный магазин";
			this.n = 0;
			this.cash = 0;
		}

		public Shop(string name, int n, int cash, Laptop[] laptop)
		{
			this.name = name;
			this.n = n;
			this.cash = cash;
			for (int i = 0; i < n; i++)
			{
				this.laptop[i] = laptop[i];
			}
		}

		public Shop(string name, int n, int cash, Laptop laptop)
		{
			int i = 0;
			this.name = name;
			this.n = n;
			this.cash = cash;
			this.laptop[i] = laptop;
		}
		public Laptop getlaptop(int n)
		{
			return laptop[n];
		}
		public double getprice(int i)
		{
			return laptop[i].getprice();
		}
		public int getcpu(int i)
		{
			return laptop[i].getcpu();
		}
		public int getram(int i)
		{
			return laptop[i].getram();
		}
		public int getyear(int i)
		{
			return laptop[i].getyear();
		}
		public string getmodel(int i)
		{
			return laptop[i].getmodel();
		}
		~Shop()
		{
		}

		public void set_Shop(string name, int n, int cash, Laptop[] laptop)
		{
			this.name = name;
			this.n = n;
			this.cash = cash;
			for (int i = 0; i < N; i++)
			{
				this.laptop[i] = laptop[i];
			}
		}

		public void print_shop(int n)
		{
			Console.WriteLine("Название магазина: " + name);
			Console.WriteLine("Количество моделей ноутбуков: " + n);
			Console.WriteLine("Средства: " + cash);
			Console.WriteLine("Модели: ");
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(i + 1 + ": " + laptop[i].getmodel() + " Цена: " + laptop[i].getprice());
			}
			Console.WriteLine("");
		}

		public int purchase()
		{
			Console.WriteLine("\tПокупаем ноутбук");
			Laptop a = new Laptop();
			string model;
			int ram, cpu, year;
			double price;
			Console.WriteLine("Введите характеристики нового ноутбука");
			Console.WriteLine("Модель: ");
			model = Console.ReadLine();
			Console.WriteLine("Объем оперативной памяти: ");
			ram = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Частота процессора: ");
			cpu = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Цена ноутбука: ");
			price = Double.Parse(Console.ReadLine());
			Console.WriteLine("Год производства: ");
			year = Int32.Parse(Console.ReadLine());
			a.set_laptop(model, ram, cpu, price * 1.1, year);
			this.laptop[n] = a;
			n = n + 1;
			cash = cash - price;
			Console.WriteLine("");
			return n;
		}
		public int sale(int n)
		{
			Console.WriteLine("\tПродаем");
			for (int i = 0; i <= n; i++)
			{
				cash += this.getprice(i);
				n -= 1;
				Console.WriteLine(this.getmodel(i) + " продан!");
			}
			n = 0;
			Console.WriteLine();
			return n;
		}
		public void add_price(int n)
		{
			double sumprice = 0;
			for (int i = 0; i < n; i++)
			{
				sumprice = sumprice + this.getprice(i);
			}
			Console.WriteLine(sumprice);
		}
		public void add_price(Laptop a1, Laptop a2)
		{
			Console.WriteLine(a1.getprice() + a2.getprice());
		}
		public void compare(int n)
		{

			Console.WriteLine("*******************************");
			for (int i = 0; i < n; i++)
			{

				Console.WriteLine("Модель ноутбука: " + this.getmodel(i));
			}
			Console.WriteLine("*******************************");
			double maxprice = this.getprice(0);
			double minprice = this.getprice(0);

			int maxcpu = this.getcpu(0);
			int mincpu = this.getcpu(0);

			int maxram = this.getram(0);
			int minram = this.getram(0);

			int maxyear = this.getyear(0);
			int minyear = this.getyear(0);

			for (int i = 0; i < n; i++)
			{
				if (this.getprice(i) > maxprice)
					maxprice = this.getprice(i);

				if (this.getprice(i) < minprice)
					minprice = this.getprice(i);
			}

			for (int i = 0; i < n; i++)
			{
				if (this.getcpu(i) > maxcpu)
					maxcpu = this.getcpu(i);

				if (this.getcpu(i) < mincpu)
					mincpu = this.getcpu(i);
			}

			for (int i = 0; i < n; i++)
			{
				if (this.getram(i) > maxram)
					maxram = this.getram(i);

				if (this.getram(i) < minram)
					minram = this.getram(i);
			}

			for (int i = 0; i < n; i++)
			{
				if (this.getyear(i) > maxyear)
					maxyear = this.getyear(i);

				if (this.getyear(i) < minyear)
					minyear = this.getyear(i);
			}

			Console.WriteLine("Самый дорогой ноутбук стоит "+maxprice+" р.");
			Console.WriteLine("Самый дешевый ноутбук стоит " + minprice + " р.");

			Console.WriteLine("Самая большая оперативная память среди ноутбуков "+maxram + " гб." );
			Console.WriteLine("Самая маленькая оперативная память среди ноутбуков " +minram + " гб.");

			Console.WriteLine("Самая большая частота процессора среди ноутбуков " +maxcpu + " гц.");
			Console.WriteLine("Самая маленькая частота процессора среди ноутбуков " + mincpu +" гц.");

			Console.WriteLine("Самый новый ноутбук " + maxyear + " г.");
			Console.WriteLine("Самый старый ноутбук "+ minyear+ " г.");
		}

		public void compare(Laptop a1, Laptop a)
		{
			int ram, cpu, year;
			double price;

			Console.WriteLine("Сравниваем ноутбуки " + a1.getmodel() + " и " + a.getmodel());
			if (a1.getram() > a.getram())
			{
				ram = a1.getram() - a.getram();
				Console.WriteLine("Оперативная память ноутбука " + a1.getmodel() + " больше оперативной памяти ноутбука " + a.getmodel() + " на " + ram + " гб." );
			}
			if (a1.getram() < a.getram())
			{
				ram = a.getram() - a1.getram();
				Console.WriteLine("Оперативная память ноутбука " + a.getmodel() + " больше оперативной памяти ноутбука " + a1.getmodel() + " на " + ram + " гб.");
			}
			if (a1.getram() == a.getram())
			{

				Console.WriteLine("Оперативная память ноутбуков совпадает и = " + a.getram() + " гб.");
			}
			// сравниваем по частоте
			if (a1.getcpu() > a.getcpu())
			{
				cpu = a1.getcpu() - a.getcpu();
				Console.WriteLine("Частота процессора ноутбука " + a1.getmodel() + " больше частоты процессора ноутбука " + a.getmodel() + " на " + cpu + " гц." );
			}
			if (a1.getcpu() < a.getcpu())
			{
				cpu = a.getcpu() - a1.getcpu();
				Console.WriteLine("Частота процессора ноутбука " + a.getmodel() + " больше частоты процессора ноутбука " + a1.getmodel() + " на " + cpu + " гц.");
			}
			if (a1.getram() == a.getram())
			{

				Console.WriteLine("Частоты процессоров ноутбуков совпадают и = " + a1.getram() +" гц.");
			}
			// сравниваем по цене
			if (a1.getprice() > a.getprice())
			{
				price = a1.getprice() - a.getprice();
				Console.WriteLine("Цена ноутбука " + a1.getmodel() + " больше цены ноутбука " + a.getmodel() + " на " + price + " р.");
			}
			if (a1.getprice() < a.getprice())
			{
				price = a.getprice() - a1.getprice();
				Console.WriteLine("Цена ноутбука " + a.getmodel() + " больше цены ноутбука " + a1.getmodel() + " на " + price + " р.");
			}
			if (a1.getprice() == a.getprice())
			{

				Console.WriteLine("Цены ноутбуков совпадают и = " + a1.getprice() + " р.");
			}
			// сравниваем по году выпуска
			if (a1.getyear() > a.getyear())
			{
				year = a1.getyear() - a.getyear();
				Console.WriteLine("Год выпуска ноутбука " + a1.getmodel() + " позже года выпуска ноутбука " + a.getmodel() + " на " + year + " г.");
			}
			if (a1.getyear() < a.getyear())
			{
				year = a.getyear() - a1.getyear();
				Console.WriteLine( "Год выпуска ноутбука " + a.getmodel() + " позже года выпуска ноутбука " + a1.getmodel() + " на " + year + " г.");
			}
			if (a1.getyear() == a.getyear())
			{

				Console.WriteLine("Годы выпуска ноутбуков совпадают и = " + a1.getyear() + " г.");
			}
		}

	};


}


	