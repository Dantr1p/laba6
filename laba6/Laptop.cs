using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
    class Laptop
    {
        private String model;
        private int RAM;
        private int CPU;
        private double price;
        private int year;
        public Laptop()
        {
            this.model = "No model";
            this.RAM = 0;
            this.CPU = 0;
            this.price = 0;
            this.year = 0;
        }
        public Laptop(String model, int RAM, int CPU, double price, int year)
        {
            this.model = model;
            this.RAM = RAM;
            this.CPU = CPU;
            this.price = price;
            this.year = year;
        }
		~Laptop()
		{

		}
		public void set_laptop(string model, int ram, int cpu, double price, int year)
		{
			this.model = model;
			this.RAM = ram;
			this.CPU = cpu;
			this.price = price;
			this.year = year;
		}
		public void print_laptop()
		{
			Console.WriteLine("Модель ноутбука: " +model);
			Console.WriteLine("Объем оперативной памяти: " + RAM);
			Console.WriteLine("Частота процессора: " + CPU);
			Console.WriteLine("Цена ноутбука: " + price);
			Console.WriteLine("Год производства: " + year);			
		}
		public string getmodel()
		{
			return model;
		}
		public int getram()
		{
			return RAM;
		}
		public int getcpu()
		{
			return CPU;
		}
		public int getyear()
		{
			return year;
		}
		public double getprice()
		{
			return price;
		}
	};


}

