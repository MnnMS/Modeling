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

            /*for (int i = 0; i < 3; i++)
            {
                MessageBox.Show("Customer No. " + system.SimulationTable[i].CustomerNumber);
                MessageBox.Show("Random dig interarrival. " + system.SimulationTable[i].RandomInterArrival);
                MessageBox.Show("interarrival. " + system.SimulationTable[i].InterArrival);
                MessageBox.Show("arrival. " + system.SimulationTable[i].ArrivalTime);
                MessageBox.Show("server id. " + system.SimulationTable[i].AssignedServer.ID);
                MessageBox.Show("time begin. " + system.SimulationTable[i].StartTime);
                MessageBox.Show("random dig service. " + system.SimulationTable[i].RandomService);
                MessageBox.Show("service time. " + system.SimulationTable[i].ServiceTime);
                MessageBox.Show("end time. " + system.SimulationTable[i].EndTime);
                MessageBox.Show("queue. " + system.SimulationTable[i].TimeInQueue);
            }*/
            
        }
    }
}
