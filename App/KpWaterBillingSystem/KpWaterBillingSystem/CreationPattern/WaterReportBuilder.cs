using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.CreationPattern
{
    public class WaterReportBuilder
    {
        private WaterReport report = new WaterReport();

        public WaterReportBuilder AddSummary(string summary)
        {
            report.Summary = summary;
            return this;
        }

        public WaterReportBuilder AddImage(string image)
        {
            report.Image = image;
            return this;
        }

        public WaterReportBuilder AddNotes(string notes)
        {
            report.Notes = notes;
            return this;
        }

        public WaterReport Build() => report;
    }
}
