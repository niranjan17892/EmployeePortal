using System;
using Employee_Monthly_Salary_Pay_Slip.Interfaces;

namespace Employee_Monthly_Salary_Pay_Slip.Services
{

    public class TaxService : ITaxService
    {

        public double CalculateIncomeTax(double taxableIncome)
        {
            double incme_Tax;
            switch (CalculateRange(taxableIncome))
            {
                case 0:
                    return 0;
                case 1:
                    incme_Tax = Math.Round(((taxableIncome - 18200) * 0.0019) / 12);
                    return incme_Tax;
                case 2:
                    incme_Tax = Math.Round((3572 + (taxableIncome - 37000) * 0.325) / 12);
                    return incme_Tax;

                case 3:
                    incme_Tax = Math.Round((19822 + (taxableIncome - 87000) * 0.37) / 12);
                    return incme_Tax;
                case 4:
                    incme_Tax = Math.Round((54232 + (taxableIncome - 180000) * 0.45) / 12);
                    return incme_Tax;

                default:
                    return 0;
            }
        }


        // Returns taxable income type based on taxable income.
        private int CalculateRange(double taxableIncome)
        {
            // Todo: Revisit the logic to handle the income type.

            if (taxableIncome >= 0)
            {
                if (taxableIncome > 0 && taxableIncome <= 18200)
                {
                    return 0;
                }
                if (taxableIncome > 18200 && taxableIncome <= 37000)
                {
                    return 1;
                }
                if (taxableIncome > 37000 && taxableIncome <= 87000)
                {
                    return 2;
                }
                if (taxableIncome > 87000 && taxableIncome <= 180000)
                {
                    return 3;
                }
                if (taxableIncome > 180000)
                {
                    return 4;
                }

            }

            return 0;

        }
    }
}
