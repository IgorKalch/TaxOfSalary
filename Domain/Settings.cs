using System;
using System.Collections.Generic;
using System.Text;

namespace IKalchenko.TaxOfSalary.Domain
{
    public class Settings
    {
        /// <summary>
        /// The first  525.12 PLN of tax in a calendar year should not be paid
        /// </summary>
        public const decimal TaxReduced = 525.12M;

        /// <summary>
        /// Converter to dollars
        /// </summary>
        public const decimal ConverterFromUSD = 4.3M;

        /// <summary>
        /// Converter to euro
        /// </summary>
        public const decimal ConverterFromEUR = 4.6M;

        /// <summary>
        /// Flat tax (rigid 19% percentage of salary)
        /// </summary>
        public const decimal FlatTax = 0.19M;

        /// <summary>
        /// The first 85528 PLN of an employee's salary in a calendar year is subject to 17% tax
        /// </summary>
        public const decimal FirstTaxThreshold = 85528M;

        /// <summary>
        /// The first 85528 PLN of an employee's salary in a calendar year is subject to 17% tax
        /// </summary>
        public const decimal ProgressiveTaxFirstThreshold = 0.17M;

        /// <summary>
        /// Salaries which cumulatively in a year exceed PLN 85528 are subject to 32% tax
        /// </summary>
        public const decimal ProgressiveTaxSecondThreshold = 0.32M;
    }
}
