using IKalchenko.TaxOfSalary.Domain;
using IKalchenko.TaxOfSalary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKalchenko.TaxOfSalary.TaxOfSalaryConsole
{
    class Program
    {
       static void Main(string[] args)
        {
            MemoryRepository memoryRepository = new MemoryRepository();
            List<ValueRecord> valueRecords = memoryRepository.ValueRecordGet();
          
            Calculation calculation = new Calculation();           

            Console.WriteLine("Choose your tax rate 1.Tax exemption. 2.Flat tax. 3.Progressive tax");
            var taxChoise = Console.ReadLine();

            calculation.TaxCalculate(taxChoise, valueRecords);

            Console.ReadLine();
        }
    }
}
