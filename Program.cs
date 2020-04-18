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
				Console.WriteLine($"Я зарабатываю {20 * trf} $");
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
			Console.ReadLine();
		}
	}
}
