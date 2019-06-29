using System;
using System.Globalization;
using System.Collections.Generic;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos empregado serão registrados? ");
            int qEmpregado = int.Parse(Console.ReadLine());
            List<Empregado> Lista = new List<Empregado>();
            

            for (int i = 0; i < qEmpregado; i++)
            {
                Console.WriteLine("Empregado nº " + (i+1));
                Console.Write("Id: ");
                int indice = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Lista.Add(new Empregado(indice, nome, salario));
                Console.WriteLine();
                
            }

            Console.Write("Entre com o id do empregado que terá o salário acrescentado: ");
            int ide = int.Parse(Console.ReadLine());
            Empregado Emp = Lista.Find(x => x.Id == ide);
            if (Emp != null)
            {
                Console.Write("Entre com a porcentagem para acrécimo: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Emp.Acrescentar(valor);

            }
            Console.WriteLine("Lista de valores acrentada:");
            foreach (Empregado obj in Lista)
                Console.WriteLine(obj);

        }
    }
}
