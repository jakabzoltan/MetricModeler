using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetricModelGrp28.UniqueMetrics;

namespace MetricModelGrp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cboFrameworkUsed.Items.Clear();
            cboFrameworkUsed.Items.AddRange(Constants.GetFrameworkPoints().Select(x=>x.FrameworkName).ToArray());
            cboDeveloperSkillLevel.Items.Clear();
            cboDeveloperSkillLevel.Items.AddRange(Constants.GetDeveloperSkills().Select(x => x.Name).ToArray());
            cboProgrammingLanguage.Items.Clear();
            cboProgrammingLanguage.Items.AddRange(Constants.GetLanguagePoints().Select(x => x.Language).ToArray());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var calculationHandler = new CalculationHandler(
                numNumberOfDevelopers.Value,
                numNumberOfFunctionPoints.Value,
                Constants.GetLanguagePoints().FirstOrDefault(x => x.Language == cboProgrammingLanguage.SelectedText),
                new ZoltanMetric(numModelCount.Value),
                new StevenMetric(),
                new VictorMetric(cboFrameworkUsed.SelectedText),
                new TylerMetric());
        }
    }
}