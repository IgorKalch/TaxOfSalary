using System;
using System.Collections.Generic;

namespace IKalchenko.TaxOfSalary.Domain
{
    public class Calculation
    {
        /// <summary>
        /// Income tax calculation
        /// 1.Tax free
        /// 2.Flat tax
        /// 3.Progressive tax
        /// </summary>
        /// <param name="taxChoise"> Method of accounting  for  tax</param>
        /// <param name="valueRecords">List of data</param>
        public void TaxCalculate(string taxChoise, List<ValueRecord> valueRecords)
        {
            var currencyConverter = new CurrencyConverter();
            decimal totalSalary = currencyConverter.CurrencyConvert(valueRecords);

            decimal salaryAfterTaxRate;
            decimal taxRate;

            int roundDowSalaryAfterTaxRate;
            int roundDownTaxRate;           
            
            switch (taxChoise)
            {
                case "1":
                    salaryAfterTaxRate = totalSalary;
                    roundDowSalaryAfterTaxRate = Convert.ToInt32(Math.Floor(salaryAfterTaxRate));
                    Console.WriteLine($"Your salary: {roundDowSalaryAfterTaxRate}" );
                    break;
                case "2":
                    taxRate = totalSalary * Settings.FlatTax;
                    salaryAfterTaxRate = totalSalary - taxRate;
                    roundDowSalaryAfterTaxRate = Convert.ToInt32(Math.Floor(salaryAfterTaxRate));
                    roundDownTaxRate = Convert.ToInt32(Math.Floor(taxRate));
                    Console.WriteLine($"Your salary: {roundDowSalaryAfterTaxRate} and your tax: {roundDownTaxRate}");
                    break;
                case "3":
                    progressiveTaxCalculation(totalSalary);
                    break;
                default:
                    Console.WriteLine("Wrong choose");
                    break;
            }
        }

        /// <summary>
        /// Calculation of progressive tax
        /// First 85528 PLN - 17% tax
        /// Over 85528 PLN - 32% tax 
        /// The first PLN 525.12 of accrued tax in a calendar year does not have to be paid
        /// </summary>
        /// <param name="salaryBeforeTaxRate">Total salary before tax rate</param>
        private void progressiveTaxCalculation (decimal salaryBeforeTaxRate) 
        {
            decimal salaryAfterTaxRateSmaller;
            decimal salaryAfterTaxRateBigger;
            decimal taxRateSmaller;
            decimal taxRateBigger;
            

            int roundDowSalaryAfterFirstTaxRate;
            int roundDowSalaryAfterSecondTaxRate;
            int roundDownFirstTaxRate;
            int roundDownSecondTaxRate;

            taxRateSmaller = Settings.FirstTaxThreshold * Settings.ProgressiveTaxFirstThreshold ;

            salaryAfterTaxRateSmaller = Settings.FirstTaxThreshold - taxRateSmaller + Settings.TaxReduced;

            if (salaryBeforeTaxRate <= Settings.FirstTaxThreshold)
            {    
                roundDowSalaryAfterFirstTaxRate = Convert.ToInt32(Math.Floor(salaryAfterTaxRateSmaller));
                roundDownFirstTaxRate = Convert.ToInt32(Math.Floor(taxRateSmaller - Settings.TaxReduced));
          
                Console.WriteLine($"Your salary: {roundDowSalaryAfterFirstTaxRate} and your tax: {roundDownFirstTaxRate}");
            }
            else
            {
               taxRateBigger = (salaryBeforeTaxRate - Settings.FirstTaxThreshold) * Settings.ProgressiveTaxSecondThreshold;

                salaryAfterTaxRateBigger = (salaryBeforeTaxRate - Settings.FirstTaxThreshold) - taxRateBigger;

               roundDowSalaryAfterSecondTaxRate = Convert.ToInt32(Math.Floor(salaryAfterTaxRateBigger + salaryAfterTaxRateSmaller));
               roundDownSecondTaxRate = Convert.ToInt32(Math.Floor(taxRateBigger+ taxRateSmaller - Settings.TaxReduced));

               Console.WriteLine($"Your salary: {roundDowSalaryAfterSecondTaxRate} and your tax: {roundDownSecondTaxRate}");
            }
            
        }
    }
}
