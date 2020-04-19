using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10
{
	class Program
	{
		class Worker
		{
			public string Name { get; set; }
			public int trf { get; set; }
			public Worker(string name)
			{
				this.Name = name;
			}
			public virtual void MakeJob()
			{
				Console.WriteLine($"Меня зовут {Name}. Я работаю работу");
			}
			public virtual void Payroll(int trf)
			{
				this.trf = trf;
				Console.WriteLine($"Я зарабатываю {20 * this.trf} $");
			}
			public static Worker operator ++(Worker w1)
			{
				w1.trf += 5;
				return w1;
			}
			public static Worker operator -(Worker w1, int fine)
			{
				w1.trf -= fine;
				return w1;
			}

		}
		class Programmer : Worker
		{

			public Programmer(string name) : base(name) { }
			public override void MakeJob()
			{
				Console.WriteLine($"Меня зовут {Name}. Я пишу код");
			}
			public override void Payroll(int trf)
			{
				base.Payroll(trf);
				int taxes = 15 * trf / 100 * 20;
				Console.WriteLine($"И отдаю на налоги {taxes} $");
			}

		}
		static void Main(string[] args)
		{
			Worker worker = new Worker("Boba Fet");
			worker.MakeJob();
			worker.Payroll(25);
			Programmer programmer = new Programmer("Obi-Wan Kenobi");
			programmer.MakeJob();
			programmer.Payroll(50);
			worker++;
			Console.WriteLine($"Новый тариф {worker.trf} $");
			worker = worker - 15;
			Console.WriteLine($"Новый тариф c учётом штрафа {worker.trf} $");

			Console.ReadLine();
		}
	}
}
