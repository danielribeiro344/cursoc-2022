using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetosCurso.ProjetoEmpresa.Entities.Enums;
using ProjetosCurso.ProjetoEmpresa.Entities;
using System.Globalization;

namespace ProjetosCurso.ProjetoEmpresa
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Digite a data do contrato:");
            Console.WriteLine("Digite o nome do trabalhador: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o nivel do trabalhador: (Junior/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Digite o salario base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("Quantos contratos tem esse trabalhador?");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine($"Enter #{i} contract date:");
                Console.Write("Data: ");
                DateTime date = DateTime.Parse(Console.ReadLine());


                Console.WriteLine("Digite o valor da hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Console.WriteLine("Duração em horas: ");
                int hours = int.Parse(Console.ReadLine());


                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

                Console.WriteLine();
                Console.WriteLine("Entre com o mes e ano para pesquisa de contrato do trabalhador: ");
                string monthAndYear = Console.ReadLine();
                int month = int.Parse(monthAndYear.Substring(0, 2));
                int year = int.Parse(monthAndYear.Substring(3));
                Console.WriteLine("Nome: " + worker.Name);
                Console.WriteLine("Departamento: " + worker.Departament.Name);
                Console.WriteLine("Income: " + monthAndYear + ": " + worker.Income(year, month));




            }



        }
    }
}
