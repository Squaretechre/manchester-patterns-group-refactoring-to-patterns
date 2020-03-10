﻿﻿namespace MPG.FormTemplateMethod.Before
{
    public class CapitalStrategyAdvisedLine : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return loan.GetCommitment() * loan.GetUnusedPercentage() * Duration(loan) * RiskFactor(loan);
        }
    }
}