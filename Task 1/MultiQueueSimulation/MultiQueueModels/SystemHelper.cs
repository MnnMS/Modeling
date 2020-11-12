using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueModels
{
    public static class SystemHelper
    {
        public static int  NumberOfServers;
        public static int StoppingNumber;
        public static List<Server> Servers = new List<Server>();
        public static List<TimeDistribution> InterarrivalDistribution = new List<TimeDistribution>();
        public static Enums.StoppingCriteria StoppingCriteria;
        public static Enums.SelectionMethod SelectionMethod;

        public static int TotalTime_CusWaitedinQueue;
        public static int ncustomers_Total;
        public static int nCustomers_WaitedInQueue;
        public static int Simulation_runTime;
        public static int mx_QueueLength;

        //to save all start , end time service and server id
        public static List<Serviceinfo> servicesinfo;

        //Variables for every server
        public static List<int> idleTimeOFserver = new List<int>();
        public static List<int> serviceTime = new List<int>();
        public static List<int> nCustomers_server = new List<int>();
        public static List<int> TimeOnCalls_server = new List<int>();

        public static void start(SimulationSystem system)
        {
            system = new SimulationSystem(NumberOfServers, StoppingNumber, Servers, InterarrivalDistribution, StoppingCriteria, SelectionMethod);
            system.SimulationTable = SimulationCase.getTable(StoppingNumber, system);
            for(int i = 0; i < system.SimulationTable.Count; i++)
            {
                MessageBox.Show("Customer No. " + system.SimulationTable[i].CustomerNumber);
                MessageBox.Show("Random dig interarrival. " + system.SimulationTable[i].RandomInterArrival);
                MessageBox.Show("interarrival. " + system.SimulationTable[i].InterArrival);
                MessageBox.Show("arrival. " + system.SimulationTable[i].ArrivalTime);
                MessageBox.Show("random dig service. " + system.SimulationTable[i].RandomService);
                MessageBox.Show("server id. " + system.SimulationTable[i].AssignedServer.ID);
                MessageBox.Show("time begin. " + system.SimulationTable[i].StartTime);
                MessageBox.Show("service time. " + system.SimulationTable[i].ServiceTime);
                MessageBox.Show("end time. " + system.SimulationTable[i].EndTime);
                MessageBox.Show("queue. " + system.SimulationTable[i].TimeInQueue);
            }
        }
        

    }

    
}
