using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;

public class BillingManager
{
    private readonly IReport _report;

    public BillingManager(IReport report)
    {
        _report = report;
    }

    public decimal CalculateBill(int usageInKilolitres, decimal ratePerKilolitre)
    {
        if (usageInKilolitres < 0 || ratePerKilolitre < 0)
        {
            throw new ArgumentException("Usage and rate must be non-negative.");
        }

        return usageInKilolitres * ratePerKilolitre;
    }

    public string GenerateReport()
    {
        return _report.Generate();
    }
}

