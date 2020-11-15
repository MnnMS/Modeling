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

namespace MultiQueueSimulation
{
    public partial class ServerBusyTimeGraph : Form
    {
        public ServerBusyTimeGraph(int serverNum)
        {
            InitializeComponent();
            label1.Text = "Server" + serverNum + " Busy Time Graph";
            List<Serviceinfo> servicesinfo = SystemHelper.servicesinfo.FindAll(s => s.ID == serverNum);
            if(servicesinfo.Count==0)
            this.chart1.Series["Busy"].Points.AddXY(0,0);
            foreach (var serviceinfo in servicesinfo) { 
                this.chart1.Series["Busy"].Points.AddXY(serviceinfo.StartTime,0);
                this.chart1.Series["Busy"].Points.AddXY(serviceinfo.StartTime,1);
                this.chart1.Series["Busy"].Points.AddXY(serviceinfo.EndTime,1);
                this.chart1.Series["Busy"].Points.AddXY(serviceinfo.EndTime,0);
            }
        }

        private void ServerBusyTimeGraph_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
