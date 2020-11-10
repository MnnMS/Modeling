using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationCase
    {
        public SimulationCase()
        {
            this.AssignedServer = new Server();
        }

        public int CustomerNumber { get; set; }
        public int RandomInterArrival { get; set; }
        public int InterArrival { get; set; }
        public int ArrivalTime { get; set; }
        public int RandomService { get; set; }
        public int ServiceTime { get; set; }
        public Server AssignedServer { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int TimeInQueue { get; set; }

        public static List<SimulationCase> getTable(int stoppingNumber, SimulationSystem system)
        {
            List<Server> servers = system.Servers;
            List<SimulationCase> table = new List<SimulationCase>();
            Random rnd = new Random();
            for(int i = 0; i < stoppingNumber; i++)
            {
                SimulationCase prevRow = new SimulationCase();
                if (i > 0) {
                    prevRow = table[i - 1];
                }
                SimulationCase row = new SimulationCase();
                row.CustomerNumber = i+1;
                row.RandomInterArrival = rnd.Next(1, 100);
                row.InterArrival = mapValue(row.RandomInterArrival, system.InterarrivalDistribution);
                row.ArrivalTime = (i == 0 ? 0 : prevRow.ArrivalTime + row.InterArrival);
                
                var x = system.SelectionMethod;
                int serverIndex = 0;
                if (x == Enums.SelectionMethod.HighestPriority)
                {
                    if (i == 0)
                        row.AssignedServer = servers[0];
                    else
                    {
                        bool found = false;
                        for (int j = 0; j < servers.Count; j++)
                        {
                            if (row.ArrivalTime >= servers[j].FinishTime)
                            {
                                found = true;
                                serverIndex = j;
                                break;
                            }
                        }
                        if (!found)
                            row.AssignedServer = getFirstServer(servers);
                        else
                            row.AssignedServer = servers[serverIndex];
                    }
                }
                else if(x == Enums.SelectionMethod.Random)
                {
                    serverIndex = rnd.Next(0, servers.Count - 1);
                    if (i == 0)
                        row.AssignedServer = servers[serverIndex];
                    bool found = false;
                    do
                    {
                        if (row.ArrivalTime >= servers[serverIndex].FinishTime)
                            found = true;
                        else
                            serverIndex = rnd.Next(0, servers.Count - 1);
                    } while (!found);
                    if (found)
                        row.AssignedServer = servers[serverIndex];
                    else
                        row.AssignedServer = getFirstServer(servers);
                }
                /* else utilization [bonus]
                {

                }*/
                row.RandomService = rnd.Next(1, 100);
                row.ServiceTime = mapValue(row.RandomService, row.AssignedServer.TimeDistribution);
                row.StartTime = row.ArrivalTime + row.TimeInQueue;
                row.EndTime = row.StartTime + row.ServiceTime;
                servers[serverIndex].FinishTime = row.EndTime;
                table.Add(row);
            }
            return table;
        }

        public static Server getFirstServer(List<Server> servers)
        {
            int mnFinishTime = int.MaxValue;
            int mnFinishTime_index = 0;
            for (int j = 0; j < servers.Count; j++)
            {
                if (servers[j].FinishTime < mnFinishTime)
                {
                    mnFinishTime = servers[j].FinishTime;
                    mnFinishTime_index = j;
                }
            }
            return servers[mnFinishTime_index];
        }

        public static int mapValue(int value, List<TimeDistribution> distributions)
        {
            for(int i = 0; i < distributions.Count; i++)
            {
                TimeDistribution distribution = distributions[i];
                if(value>=distribution.MinRange && value <= distribution.MaxRange)
                {
                    return distribution.Time;
                }
            }
            return -1;
        }
    }
}
