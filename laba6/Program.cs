using System;

namespace laba6
{
    class Program
    {
        static void Main(string[] args)
        {
			const int N= 30;
			int n = 1;
			double cash = 0;
			
			Laptop lap1= new Laptop("Acer", 4, 2500, 35000, 2015);
			cash = lap1.getprice() + cash;
			Shop store=new Shop("DND", 1, 0, lap1);
			store.print_shop(n);
			n = store.purchase();
			store.print_shop(n);
			store.add_price(store.getlaptop(0), store.getlaptop(1));
			store.compare(store.getlaptop(0), store.getlaptop(1));
			n = store.sale(n);
			store.print_shop(n);

					

			
			Laptop[] lap3 = new Laptop[N];
			Console.WriteLine("Введите количество ноутбуков: ");
			n=Int32.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string model = "";
				int cpu = 0, ram = 0, year = 0;
				double price = 0;
				Console.WriteLine( "Введите модель ноутбука: ");
				model=Console.ReadLine();
				Console.WriteLine( "Объем оперативной памяти(гб): ");
				ram=Int32.Parse(Console.ReadLine());
				Console.WriteLine("Введите частоту процессора: ");
				cpu = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Введите стоимость ноутбука: " );
				price=double.Parse(Console.ReadLine());
				Console.WriteLine("Введите год производства ноутбука: ");
				year= Int32.Parse(Console.ReadLine()); 
				lap3[i].set_laptop(model, ram, cpu, price, year);
			}
			Shop store2 = new Shop("DNM", n, 0, lap3);
			store2.print_shop(n);
			n = store2.purchase(); //
			store2.print_shop(n);
			store2.add_price(n);
			store2.compare(n);
			n = store2.sale(n + 2);
			store2.print_shop(n);
			

			
		}

	}
}

