using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;
using MultiQueueSimulation;

namespace MultiQueueSimulation
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
            SystemHelper.TotalTime_CusWaitedinQueue = 0;
            SystemHelper.nCustomers_WaitedInQueue = 0;
            SystemHelper.Simulation_runTime = 0;
            SystemHelper.mx_QueueLength = 0;
        }

        private void numOfServers_TextChanged(object sender, EventArgs e)
        {
            
            DataTable inputTable = new DataTable();
            int num_of_servers = 0;
            try
            {
                num_of_servers = int.Parse(numOfServers.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter the number of servers");
            }
            system.NumberOfServers = num_of_servers;
            system.initSevers();
            

            inputTable.Columns.Add("Interarrival Time");
            inputTable.Columns.Add("Probability");

            for (int i = 1; i <= num_of_servers; i++)
            {
                inputTable.Columns.Add("Service Time " + i);
                inputTable.Columns.Add("Probability " + i);
            }
            inputGridView.DataSource = inputTable;
            inputGridView.Visible = true;
           
        }

        private void stopNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                system.StoppingNumber = int.Parse(stopNum.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter the stopping number");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            system.StoppingCriteria = (Enums.StoppingCriteria)int.Parse(comboBox1.Text);          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            system.SelectionMethod = (Enums.SelectionMethod)int.Parse(comboBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int rowCount = inputGridView.Rows.Count;
            int colCount = inputGridView.Columns.Count;
            for (int i = 0; i <(rowCount-1); i++)
            {
             
                TimeDistribution timeDistribution = new TimeDistribution
                {
                    Time = int.Parse(inputGridView.Rows[i].Cells[0].Value.ToString()),
                    Probability = decimal.Parse(inputGridView.Rows[i].Cells[1].Value.ToString())
                };
                system.InterarrivalDistribution.Add(timeDistribution);
                for (int j=0; j < system.NumberOfServers; j++)
                {
                    timeDistribution = new TimeDistribution
                    {
                        Time = int.Parse(inputGridView.Rows[i].Cells[j * 2 + 2].Value.ToString()),
                        Probability = decimal.Parse(inputGridView.Rows[i].Cells[j * 2 + 3].Value.ToString())
                    };
                    system.Servers[j].TimeDistribution.Add(timeDistribution);
                }
            }

            system.InterarrivalDistribution = TimeDistribution.Get_DistributionTable(system.InterarrivalDistribution);
            for(int i=0;i< system.NumberOfServers; i++)
            {
                system.Servers[i].TimeDistribution = TimeDistribution.Get_DistributionTable(system.Servers[i].TimeDistribution);
            }

            system.genTable();
            system.calc_performance();
            system.PerformanceMeasures.Calc_AverageWaitingTime(SystemHelper.TotalTime_CusWaitedinQueue, SystemHelper.nCustomers_Total);
            system.PerformanceMeasures.Calc_WaitingProbability(SystemHelper.nCustomers_WaitedInQueue, SystemHelper.nCustomers_Total);
            system.PerformanceMeasures.MaxQueueLength = SystemHelper.mx_QueueLength;

            
            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
            int custNo = SystemHelper.nCustomers_Total;
            outputGridView.Rows.Add(custNo);
            for (int i = 0; i < custNo; i++)
            {                
                outputGridView.Rows[i].Cells[0].Value = system.SimulationTable[i].CustomerNumber;
                outputGridView.Rows[i].Cells[1].Value = system.SimulationTable[i].RandomInterArrival;
                outputGridView.Rows[i].Cells[2].Value = system.SimulationTable[i].InterArrival;
                outputGridView.Rows[i].Cells[3].Value = system.SimulationTable[i].ArrivalTime;
                outputGridView.Rows[i].Cells[4].Value = system.SimulationTable[i].AssignedServer.ID;
                outputGridView.Rows[i].Cells[5].Value = system.SimulationTable[i].StartTime;
                outputGridView.Rows[i].Cells[6].Value = system.SimulationTable[i].RandomService;
                outputGridView.Rows[i].Cells[7].Value = system.SimulationTable[i].ServiceTime;
                outputGridView.Rows[i].Cells[8].Value = system.SimulationTable[i].EndTime;
                outputGridView.Rows[i].Cells[9].Value = system.SimulationTable[i].TimeInQueue;
            }
            avgWaitTime.Text = system.PerformanceMeasures.AverageWaitingTime.ToString();
            maxQueueLength.Text = system.PerformanceMeasures.MaxQueueLength.ToString();
            waitingProb.Text = system.PerformanceMeasures.WaitingProbability.ToString();

            int serverCount = system.Servers.Count;
            outputGridView2.Rows.Add(custNo);
            for (int i = 0; i < serverCount; i++)
            {
                
                outputGridView2.Rows[i].Cells[0].Value = system.Servers[i].ID;
                outputGridView2.Rows[i].Cells[1].Value = Math.Round(system.Servers[i].IdleProbability,2);
                outputGridView2.Rows[i].Cells[2].Value = Math.Round(system.Servers[i].AverageServiceTime,2);
                outputGridView2.Rows[i].Cells[3].Value = Math.Round(system.Servers[i].Utilization,2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
