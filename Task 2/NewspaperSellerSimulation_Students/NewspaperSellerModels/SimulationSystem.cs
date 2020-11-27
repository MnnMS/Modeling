using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }



        public void fillTable()
        {
            SimulationCase simulationCase;
            Random random = new Random();
            for (int i = 1; i <= NumOfRecords; i++)
            {
                simulationCase = new SimulationCase();
                simulationCase.DayNo = i;
                simulationCase.RandomNewsDayType = random.Next(1, 100);
                simulationCase.NewsDayType = getDayType(simulationCase.RandomNewsDayType);
                simulationCase.RandomDemand = random.Next(1, 100);
                simulationCase.Demand = getDemand(simulationCase.RandomDemand, simulationCase.NewsDayType);
                simulationCase.DailyCost = NumOfNewspapers * PurchasePrice;
                simulationCase.SalesProfit = NumOfNewspapers >= simulationCase.Demand ? simulationCase.Demand * SellingPrice : NumOfNewspapers * SellingPrice;

                if (NumOfNewspapers < simulationCase.Demand)
                {
                    simulationCase.LostProfit = (simulationCase.Demand - NumOfNewspapers) * (SellingPrice - PurchasePrice);
                    PerformanceMeasures.DaysWithMoreDemand++;
                }
                else
                {
                    simulationCase.LostProfit = 0;
                }
                if (NumOfNewspapers > simulationCase.Demand)
                {
                    simulationCase.ScrapProfit = (NumOfNewspapers - simulationCase.Demand) * ScrapPrice;
                    PerformanceMeasures.DaysWithUnsoldPapers++;
                }
                else
                {
                    simulationCase.ScrapProfit = 0;
                }
                
                simulationCase.DailyNetProfit = (simulationCase.SalesProfit + simulationCase.ScrapProfit) - simulationCase.LostProfit - simulationCase.DailyCost;
                
                PerformanceMeasures.TotalCost += simulationCase.DailyCost; 
                PerformanceMeasures.TotalSalesProfit += simulationCase.SalesProfit;
                PerformanceMeasures.TotalLostProfit += simulationCase.LostProfit;
                PerformanceMeasures.TotalScrapProfit += simulationCase.ScrapProfit;
                PerformanceMeasures.TotalNetProfit += simulationCase.DailyNetProfit;
                
                SimulationTable.Add(simulationCase);
            }
            
        }

        public Enums.DayType getDayType(int random)
        {
            for (int i = 0; i < 3; i++)
            {
                if (random >= DayTypeDistributions[i].MinRange && random <= DayTypeDistributions[i].MaxRange)  
                {
                    return DayTypeDistributions[i].DayType;
                }
            }
            throw new Exception("Can't find Day Type");
             
        }
        public int getDemand(int random,Enums.DayType dayType)
        {
            int count = DemandDistributions.Count;
            for (int i = 0; i < count; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    if (DemandDistributions[i].DayTypeDistributions[a].DayType == dayType)
                    {
                        if (random >= DemandDistributions[i].DayTypeDistributions[a].MinRange &&
                            random <= DemandDistributions[i].DayTypeDistributions[a].MaxRange)
                        {
                            return DemandDistributions[i].Demand;
                        }
                    }
                   
                }
                
            }
            throw new Exception("Can't find Demand");
        }
    }
}
