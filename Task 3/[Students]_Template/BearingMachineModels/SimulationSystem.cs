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

        private List<int> noOfAccumRows = new List<int>();
        private List<int> noOfRows = new List<int>();
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
            int AccumRowCount = 0;
            Random random = new Random();
            int index = 0;
            for (int i = 1; i <= NumberOfBearings; i++)
            {
                int j = 0;
                CurrentSimulationCase Current_SC;
                CurrentSimulationCase prevRow = new CurrentSimulationCase();
                int rowCount = 0;
                while (true)
                {
                    prevRow = new CurrentSimulationCase();
                    if (j > 0)
                    {
                        prevRow = CurrentSimulationTable[index - 1];
                    }
                    if (prevRow.AccumulatedHours >= NumberOfHours)
                        break;
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
                    index++;
                    rowCount++;
                    AccumRowCount++;
                }
                noOfAccumRows.Add(AccumRowCount);
                noOfRows.Add(rowCount);
                SystemHelper.totalNoChangedBearings += j;
            }
                   
        }

        public void fill_proposedSimulationTable()
        {
            SystemHelper.totalDelayOfBearings = 0;         
            int tableCount = CurrentSimulationTable.Count;
            int accumHours = 0;
            Random random = new Random();
            int rowNum = 1;
            while (accumHours<NumberOfHours)
            {
                ProposedSimulationCase psc = new ProposedSimulationCase();
                
                for (int i = 0; i < NumberOfBearings; i++)
                {
                    Bearing bearing = new Bearing();
                    if (rowNum <= noOfRows[i])
                    {
                        int index = (i == 0 ? rowNum - 1 : noOfAccumRows[i - 1] + rowNum-1);
                        bearing.Index = CurrentSimulationTable[index].Bearing.Index;
                        bearing.Hours = CurrentSimulationTable[index].Bearing.Hours;
                        bearing.RandomHours = CurrentSimulationTable[index].Bearing.RandomHours;                       
                    }
                    else
                    {
                        bearing.Index = i + 1;
                        bearing.RandomHours = random.Next(1, 100);
                        bearing.Hours = get_BearingLife(bearing.RandomHours);
                    }
                    psc.Bearings.Add(bearing);
                }
                psc.FirstFailure = getFirstFailure(psc.Bearings);
                accumHours += psc.FirstFailure;
                psc.AccumulatedHours = accumHours;
                psc.RandomDelay = random.Next(1, 100);
                psc.Delay = get_delay(psc.RandomDelay);
                SystemHelper.totalDelayOfBearings += psc.Delay;
                
                ProposedSimulationTable.Add(psc);
                rowNum++;
            }
            SystemHelper.totalNoChangedBearings = rowNum - 1;


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

        private int getFirstFailure(List<Bearing> bearings)
        {
            int mini = int.MaxValue;
            for (int i = 0; i < NumberOfBearings; i++)
            {
                if (bearings[i].Hours<=mini)
                {
                    mini = bearings[i].Hours;
                }
            }
            return mini;
        }
    }
}
