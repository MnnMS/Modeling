using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimulationSystem system = new SimulationSystem();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumOfNewspapers_TextChanged(object sender, EventArgs e)
        {
            DataTable inputTable = new DataTable();
            inputTable.Columns.Add("Demand");
            inputTable.Columns.Add("Good");
            inputTable.Columns.Add("Fair");
            inputTable.Columns.Add("Poor");
            inputGridView.DataSource = inputTable;
            inputGridView.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                system.NumOfRecords = int.Parse(NumOfRecords.Text);
                system.NumOfNewspapers = int.Parse(NumOfNewspapers.Text);
                system.PurchasePrice = decimal.Parse(PurchasePrice.Text);
                system.ScrapPrice = decimal.Parse(ScrapPrice.Text);
                system.SellingPrice = decimal.Parse(SellingPrice.Text);
                system.UnitProfit = system.SellingPrice - system.PurchasePrice;
                DayTypeDistribution dayTypeDistribution = new DayTypeDistribution
                {
                    DayType = Enums.DayType.Good,
                    Probability = decimal.Parse(GoodDayDis.Text)
                };
                system.DayTypeDistributions.Add(dayTypeDistribution);
                dayTypeDistribution = new DayTypeDistribution
                {
                    DayType = Enums.DayType.Fair,
                    Probability = decimal.Parse(FairDayDis.Text)
                };
                system.DayTypeDistributions.Add(dayTypeDistribution);
                dayTypeDistribution = new DayTypeDistribution
                {
                    DayType = Enums.DayType.Poor,
                    Probability = decimal.Parse(PoorDayDis.Text)
                };
                system.DayTypeDistributions.Add(dayTypeDistribution);
                int rowCount = inputGridView.Rows.Count;
                
                for (int i = 0; i < (rowCount - 1); i++)
                {
                    DemandDistribution demandDistribution = new DemandDistribution
                    {
                        Demand = int.Parse(inputGridView.Rows[i].Cells[0].Value.ToString()),
                        DayTypeDistributions =
                        {
                            new DayTypeDistribution{DayType = Enums.DayType.Good, Probability=decimal.Parse(inputGridView.Rows[i].Cells[1].Value.ToString())},
                            new DayTypeDistribution{DayType = Enums.DayType.Fair, Probability=decimal.Parse(inputGridView.Rows[i].Cells[2].Value.ToString())},
                            new DayTypeDistribution{DayType = Enums.DayType.Poor, Probability=decimal.Parse(inputGridView.Rows[i].Cells[3].Value.ToString())}
                        }
                    };
                    system.DemandDistributions.Add(demandDistribution);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter the All Data");
            }
            panel1.Visible = true;
            showTable();
        }
        private void showTable()
        {
            inputGridView.Visible = false;
            system.DayTypeDistributions = SystemHelper.Cal_DayDistribution(system.DayTypeDistributions);
            system.DemandDistributions = SystemHelper.Cal_DemandDistribution(system.DemandDistributions);
            system.fillTable();

            string result = TestingManager.Test(system, Constants.FileNames.TestCase2);
            MessageBox.Show(result);

            int RowNum = system.NumOfRecords;
            outputGridView.Rows.Add(RowNum);
            for (int i = 0; i < RowNum; i++)
            {
                outputGridView.Rows[i].Cells[0].Value = system.SimulationTable[i].DayNo;
                outputGridView.Rows[i].Cells[1].Value = system.SimulationTable[i].RandomNewsDayType;
                outputGridView.Rows[i].Cells[2].Value = system.SimulationTable[i].NewsDayType;
                outputGridView.Rows[i].Cells[3].Value = system.SimulationTable[i].RandomDemand;
                outputGridView.Rows[i].Cells[4].Value = system.SimulationTable[i].Demand;
                outputGridView.Rows[i].Cells[5].Value = system.SimulationTable[i].SalesProfit;
                outputGridView.Rows[i].Cells[6].Value = system.SimulationTable[i].LostProfit;
                outputGridView.Rows[i].Cells[7].Value = system.SimulationTable[i].ScrapProfit;
                outputGridView.Rows[i].Cells[8].Value = system.SimulationTable[i].DailyNetProfit;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.Title = "Select a text file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(dialog.FileName);
                    system.NumOfNewspapers = Convert.ToInt32(lines[1]);
                    system.NumOfRecords = Convert.ToInt32(lines[4]);
                    
                    system.PurchasePrice = Convert.ToDecimal(lines[7]);
                    system.ScrapPrice = Convert.ToDecimal(lines[10]);
                    system.SellingPrice = Convert.ToDecimal(lines[13]);
                    string[] _separator = { ", " };
                    string[] DayTypeDistributions = lines[16].Split(_separator,3, StringSplitOptions.RemoveEmptyEntries);
                    DayTypeDistribution dayTypeDistribution = new DayTypeDistribution
                    {
                        DayType = Enums.DayType.Good,
                        Probability = decimal.Parse(DayTypeDistributions[0])
                    };
                    system.DayTypeDistributions.Add(dayTypeDistribution);
                    dayTypeDistribution = new DayTypeDistribution
                    {
                        DayType = Enums.DayType.Fair,
                        Probability = decimal.Parse(DayTypeDistributions[1])
                    };
                    system.DayTypeDistributions.Add(dayTypeDistribution);
                    dayTypeDistribution = new DayTypeDistribution
                    {
                        DayType = Enums.DayType.Poor,
                        Probability = decimal.Parse(DayTypeDistributions[2])
                    };
                    system.DayTypeDistributions.Add(dayTypeDistribution);
                    int currentLine = 19;
                    while (currentLine<lines.Count())
                    {
                        string[]  separator = {", "};
                        string[] values = lines[currentLine].Split(separator, 4, StringSplitOptions.RemoveEmptyEntries);
                        DemandDistribution demandDistribution = new DemandDistribution
                        {
                            Demand = int.Parse(values[0]),
                            DayTypeDistributions =
                        {
                            new DayTypeDistribution{DayType = Enums.DayType.Good, Probability=decimal.Parse(values[1])},
                            new DayTypeDistribution{DayType = Enums.DayType.Fair, Probability=decimal.Parse(values[2])},
                            new DayTypeDistribution{DayType = Enums.DayType.Poor, Probability=decimal.Parse(values[3])}
                        }
                        };
                        system.DemandDistributions.Add(demandDistribution);
                        currentLine++;
                    }
                    panel1.Visible = true;
                    showTable();
                }
                catch
                {
                    MessageBox.Show("You have selected a worng file!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            system = new SimulationSystem();
        }
    }
}
