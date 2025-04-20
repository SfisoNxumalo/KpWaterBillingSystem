using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.CreationPattern;
using NUnit.Framework;

namespace KpWaterBillingSystem.Tests
{
    public class BuilderPatternTests
    {
        [Test]
    public void BuildReport_ShouldReturnReportWithAllSections()
    {
        var builder = new WaterReportBuilder();
        var director = new ReportDirector(builder);

        director.BuildFullReport();
        var report = builder.GetReport();

        Assert.That(report, Is.Not.Null);
        Assert.That(report.Contains("Water Usage Data"), Is.EqualTo(true));
    }
}
}
