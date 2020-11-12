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

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            SystemHelper.NumberOfServers = num_of_servers;

            for (int i = 1; i <= num_of_servers; i++)
            {
                Server server = new Server();
                server.ID = i;
                server.FinishTime = 0;
                SystemHelper.Servers.Add(server);
            }

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
                SystemHelper.StoppingNumber = int.Parse(stopNum.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter the stopping number");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SystemHelper.StoppingCriteria = (Enums.StoppingCriteria)int.Parse(comboBox1.Text);          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SystemHelper.SelectionMethod = (Enums.SelectionMethod)int.Parse(comboBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int rowCount = inputGridView.Rows.Count;
            int colCount = inputGridView.Columns.Count;
            for (int i = 0; i <(rowCount-1); i++)
            {
                TimeDistribution timeDistribution = new TimeDistribution();
                timeDistribution.Time = int.Parse(inputGridView.Rows[i].Cells[0].Value.ToString());
                timeDistribution.Probability = decimal.Parse(inputGridView.Rows[i].Cells[1].Value.ToString());
                SystemHelper.InterarrivalDistribution.Add(timeDistribution);
                for (int j=0; j < SystemHelper.NumberOfServers; j++)
                {
                   TimeDistribution timeDistribution2 = new TimeDistribution();
                   timeDistribution2.Time = int.Parse(inputGridView.Rows[i].Cells[j*2+2].Value.ToString());
                   timeDistribution2.Probability = decimal.Parse(inputGridView.Rows[i].Cells[j*2+3].Value.ToString());
                   SystemHelper.Servers[j].TimeDistribution.Add(timeDistribution2);
                }
            }

            SystemHelper.InterarrivalDistribution = TimeDistribution.Get_DistributionTable(SystemHelper.InterarrivalDistribution);
            for(int i=0;i< SystemHelper.NumberOfServers; i++)
            {
                SystemHelper.Servers[i].TimeDistribution = TimeDistribution.Get_DistributionTable(SystemHelper.Servers[i].TimeDistribution);
            }

            SimulationSystem system = new SimulationSystem();
            SystemHelper.start(system);
            Console.WriteLine("aaaaaaaaaaaaaaaaa");
        }
    }
}
