using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DelayTimeDistribution = new List<TimeDistribution>();
            BearingLifeDistribution = new List<TimeDistribution>();

            CurrentSimulationTable = new List<CurrentSimulationCase>();
            CurrentPerformanceMeasures = new PerformanceMeasures();

            ProposedSimulationTable = new List<ProposedSimulationCase>();
            ProposedPerformanceMeasures = new PerformanceMeasures();
        }
        
        ///////////// INPUTS /////////////
        public int DowntimeCost { get; set; }
        public int RepairPersonCost { get; set; }
        public int BearingCost { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfBearings { get; set; }
        public int RepairTimeForOneBearing { get; set; }
        public int RepairTimeForAllBearings { get; set; }
        public List<TimeDistribution> DelayTimeDistribution { get; set; }
        public List<TimeDistribution> BearingLifeDistribution { get; set; }

        ///////////// OUTPUTS /////////////
        public List<CurrentSimulationCase> CurrentSimulationTable { get; set; }
        public PerformanceMeasures CurrentPerformanceMeasures { get; set; }
        public List<ProposedSimulationCase> ProposedSimulationTable { get; set; }
        public PerformanceMeasures ProposedPerformanceMeasures { get; set; }




        public void fill_currentSimulationTable ()
        {
            CurrentSimulationCase Current_SC ;
            Random random = new Random();
            for (int i = 1; i <= NumberOfBearings; i++)
            {
                int j = 0;
                CurrentSimulationCase prevRow = new CurrentSimulationCase();
                
                while (prevRow.AccumulatedHours <= NumberOfHours)
                {
                    if (j > 0)
                    {
                        prevRow = CurrentSimulationTable[j - 1];
                    }
                    Current_SC = new CurrentSimulationCase();
                    Current_SC.Bearing.Index = i;
                    Current_SC.Bearing.RandomHours = random.Next(1, 100);
                    Current_SC.Bearing.Hours = get_BearingLife(Current_SC.Bearing.RandomHours);
                    Current_SC.AccumulatedHours = (j == 0 ? Current_SC.Bearing.Hours : prevRow.AccumulatedHours + Current_SC.Bearing.Hours);
                    Current_SC.RandomDelay = random.Next(1, 100);
                    Current_SC.Delay = get_delay(Current_SC.RandomDelay);
                    SystemHelper.totalDelayOfBearings += Current_SC.Delay;

                    CurrentSimulationTable.Add(Current_SC);
                    j++;

                }
                SystemHelper.totalNoChangedBearings += (j - 1);
            }
                   
        }


        public int get_BearingLife (int random)
        {
            for (int i = 0;  i < BearingLifeDistribution.Count; i++)
            {
                if (random >= BearingLifeDistribution[i].MinRange && random <= BearingLifeDistribution[i].MaxRange)
                {
                    return BearingLifeDistribution[i].Time;
                }
            }
            throw new Exception("Can't find Life Hours");
        }

        public int get_delay (int random)
        {
            for (int i = 0; i < DelayTimeDistribution.Count; i++)
            {
                if (random >= DelayTimeDistribution[i].MinRange && random <= DelayTimeDistribution[i].MaxRange)
                {
                    return DelayTimeDistribution[i].Time;
                }
            }
            throw new Exception("Can't find Delay Time");
        }
    }
}
