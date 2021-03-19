using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineTesting;
using System.IO;
using BearingMachineModels;

namespace BearingMachineSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem system = new SimulationSystem();

        public Form1()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.Title = "Select a text file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string [] lines = File.ReadAllLines(dialog.FileName);
                    dwnTimeCTxt.Text = lines[1];
                    repairCostTxt.Text = lines[4];
                    bearCostTxt.Text = lines[7];
                    NhoursTxt.Text = lines[10];
                    NbearTxt.Text = lines[13];
                    repairTimeBTxt.Text = lines[16];
                    repairTBrsTxt.Text = lines[19];
                    int currLine = 22;
                    int index = 0;
                    while (lines[currLine] != "")
                    {
                        string[] separator = { ", " };
                        string[] values = lines[currLine].Split(separator, 4, StringSplitOptions.RemoveEmptyEntries);
                        delayDist.Rows.Add();
                        delayDist.Rows[index].Cells[0].Value = values[0];
                        delayDist.Rows[index].Cells[1].Value = values[1];
                        index++;
                        currLine++;
                    }
                    index = 0;
                    currLine += 2;
                    while (currLine < lines.Count())
                    {
                        string[] separator = { ", " };
                        string[] values = lines[currLine].Split(separator, 4, StringSplitOptions.RemoveEmptyEntries);
                        bearingDist.Rows.Add();
                        bearingDist.Rows[index].Cells[0].Value = values[0];
                        bearingDist.Rows[index].Cells[1].Value = values[1];
                        index++;
                        currLine++;
                    }
                    intializeSystem();
                }
                catch
                {
                    MessageBox.Show("Please select a file!");
                }
            }
        }
        void intializeSystem()
        {
            try
            {
                system.DowntimeCost = int.Parse(dwnTimeCTxt.Text);
                system.RepairPersonCost = int.Parse(repairCostTxt.Text);
                system.BearingCost = int.Parse(bearCostTxt.Text);
                system.NumberOfHours = int.Parse(NhoursTxt.Text);
                system.NumberOfBearings = int.Parse(NbearTxt.Text);
                system.RepairTimeForOneBearing = int.Parse(repairTimeBTxt.Text);
                system.RepairTimeForAllBearings = int.Parse(repairTBrsTxt.Text);

                decimal cumultiveProb = 0;
                for(int i=0;i < bearingDist.Rows.Count-1;i++)
                {
                    TimeDistribution td = new TimeDistribution();
                    td.Time = int.Parse(bearingDist.Rows[i].Cells[0].Value.ToString());
                    td.Probability = decimal.Parse(bearingDist.Rows[i].Cells[1].Value.ToString());
                    td.MinRange = (int)(cumultiveProb * 100 + 1);
                    cumultiveProb += td.Probability;
                    td.MaxRange = (int)(cumultiveProb * 100);
                    td.CummProbability = cumultiveProb;
                    system.BearingLifeDistribution.Add(td);
                }
                cumultiveProb = 0;
                for (int i = 0; i < delayDist.Rows.Count-1; i++)
                {
                    TimeDistribution td = new TimeDistribution();
                    td.Time = int.Parse(delayDist.Rows[i].Cells[0].Value.ToString());
                    td.Probability = decimal.Parse(delayDist.Rows[i].Cells[1].Value.ToString());
                    td.MinRange = (int)(cumultiveProb * 100 + 1);
                    cumultiveProb += td.Probability;
                    td.MaxRange = (int)(cumultiveProb * 100);
                    td.CummProbability = cumultiveProb;
                    system.DelayTimeDistribution.Add(td);
                }
                for(int i = 0; i < system.NumberOfBearings; i++)
                    propGridView.Columns.Add("Bearing " + (i + 1).ToString() + " Life", "Bearing " + (i + 1).ToString() + " Life");
            }
            catch
            {
                MessageBox.Show("Error while intializing system");
            }

        }

        private void simBtn_Click(object sender, EventArgs e)
        {
            system.fill_currentSimulationTable();
            system.CurrentPerformanceMeasures.calcPerformance(system, system.RepairTimeForOneBearing, 1);
            system.fill_proposedSimulationTable();
            system.ProposedPerformanceMeasures.calcPerformance(system, system.RepairTimeForAllBearings, system.NumberOfBearings);


            showTables();
            //test
            
        }
        void showTables()
        {
            /*currGridView.DataSource = system.CurrentSimulationTable;
            currGridView.Columns["Bearing"].Visible = false;*/
            for (int i = 0; i < system.CurrentSimulationTable.Count; i++)
            {
                currGridView.Rows.Add();
                CurrentSimulationCase sc = system.CurrentSimulationTable[i];
                currGridView.Rows[i].Cells[0].Value = sc.Bearing.Index;
                currGridView.Rows[i].Cells[1].Value = sc.Bearing.RandomHours;
                currGridView.Rows[i].Cells[2].Value = sc.Bearing.Hours;
                currGridView.Rows[i].Cells[3].Value = sc.AccumulatedHours;
                currGridView.Rows[i].Cells[4].Value = sc.RandomDelay;
                currGridView.Rows[i].Cells[5].Value = sc.Delay;
            }
            totalDelayTxt.Text = SystemHelper.totalDelayOfBearings.ToString();
            totalBearCTxt.Text = system.CurrentPerformanceMeasures.BearingCost.ToString();
            totalDelayCTxt.Text = system.CurrentPerformanceMeasures.DelayCost.ToString();
            totalDownCTxt.Text = system.CurrentPerformanceMeasures.DowntimeCost.ToString();
            totalRepairCTxt.Text = system.CurrentPerformanceMeasures.RepairPersonCost.ToString(); 
            totalCostTxt.Text = system.CurrentPerformanceMeasures.TotalCost.ToString();


            //for (int i = 0; i < system.NumberOfBearings; i++)
            //{

            //    propGridView.Columns.Add("Bearing "+ (i+1).ToString()+" Life","Bearing "+ (i+1).ToString()+" Life");
            //}
            for (int i = 0; i < system.ProposedSimulationTable.Count; i++)
            {
                propGridView.Rows.Add();               
                ProposedSimulationCase sc = system.ProposedSimulationTable[i];                
                propGridView.Rows[i].Cells[0].Value = sc.FirstFailure;
                propGridView.Rows[i].Cells[1].Value = sc.AccumulatedHours;
                propGridView.Rows[i].Cells[2].Value = sc.RandomDelay;
                propGridView.Rows[i].Cells[3].Value = sc.Delay;
                for (int a = 0; a < system.NumberOfBearings; a++)
                {
                    propGridView.Rows[i].Cells[a+4].Value = sc.Bearings[a].Hours;
                }
                
            }
            totalDelay2Txt.Text = SystemHelper.totalDelayOfBearings.ToString();
            totalBearCTxt2.Text = system.ProposedPerformanceMeasures.BearingCost.ToString();
            totalDelayCTxt2.Text = system.ProposedPerformanceMeasures.DelayCost.ToString();
            totalDownCTxt2.Text = system.ProposedPerformanceMeasures.DowntimeCost.ToString();
            totalRepairCTxt2.Text = system.ProposedPerformanceMeasures.RepairPersonCost.ToString();
            totalCostTxt2.Text = system.ProposedPerformanceMeasures.TotalCost.ToString();

            string testingResult = TestingManager.Test(system, Constants.FileNames.TestCase3);
            MessageBox.Show(testingResult);
        }
    }
}
