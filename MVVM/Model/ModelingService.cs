using BookMarket.MVVM.Model.Books;
using BookMarket.MVVM.Model.Interfaces;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using RangeSliderWpfApp;
using DevExpress.Mvvm;
using System.Windows;

namespace BookMarket.MVVM.Model
{
    public class ModelingService : IModeling
    {
        public int LowerValue_TimeDelivery { get; set; }
        public int UpperValue_TimeDelivery { get; set; }
        public int LowerValue_Threshold { get; set; }
        public int UpperValue_Threshold { get; set; }
        public int ModelingPeriod { get; set; }
        public int ModelingStep { get; set; }
        public bool IsStoped { get; set; }
        public int Days_Passed { get; set; }
        public int ReceivedOrders { get; set; }
        public int ProcessedOrders { get; set; }
        public int Profit { get; set; }
        public int CountBooks { get; set; }
        public int CompletedApplicationsPublisher { get; set; }
        public List<User> Users = new List<User>();
        public IGenerationModeling Generation_Serivce;
        private Random random = new Random();
        public ModelingService(int LV_timeDelivery, int UV_timeDelivery,int LV_threshold, int UV_threshold, int modelingPeriod, int modelingStep)
        {
            LowerValue_TimeDelivery = LV_timeDelivery;
            UpperValue_TimeDelivery = UV_timeDelivery;
            LowerValue_Threshold = LV_threshold;
            UpperValue_Threshold = UV_threshold;
            ModelingPeriod = modelingPeriod;
            ModelingStep = modelingStep;
            Generation_Serivce = new GenerationModelingService(ref Users);
            Check_Assortment();
        }
        public void Start_Modeling()
        {
            for(int i = 1; i<=ModelingPeriod; i++)
            {
                int Predel = random.Next(0, (int)Math.Round((decimal)(CountBooks / 2)));
                for(int j = 0; j<Predel; j++)
                {
                    if(Generation_Serivce.Generation_Buy(Generation_Serivce.Generation_User(), LowerValue_Threshold, UpperValue_Threshold, LowerValue_TimeDelivery, UpperValue_TimeDelivery))
                    {
                        Success_Buy();
                    }
                }
                Next_Day();
                if (i % ModelingStep == 0 || i == ModelingPeriod)
                    Step_Passed();
                if (IsStoped)
                    return;
                Thread.Sleep(1000);
            }
        }
        public void Check_Assortment()
        {          
            foreach (Book item in App._listBooks.ListBooks)
            {
                CountBooks += item.Count;
            }
        }
        public void Step_Passed()
        {
            App._statistic.DayPassedCount = Days_Passed;
            App._statistic.CompletedApplicationsPublisherStatisticCount = CompletedApplicationsPublisher;
            App._statistic.ProcessedOrdersStatisticCount = ProcessedOrders;
            App._statistic.Profit = Profit;
            App._statistic.ReceivedOrdersStatisticCount = ReceivedOrders;
        }
        public void Next_Day()
        {
            Days_Passed++;
            bool flag = false;
            for (int i = App._statement.Statement.Count - 1; i >= 0; i--)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    if (App._statement.Statement[i].DayPassed())
                    {
                        CountBooks += App._statement.Statement[i].Count;
                        App._statement.Remove(App._statement.Statement[i]);
                        CompletedApplicationsPublisher++;
                        flag = true;
                    }
                });
            }
            if(flag)
                Check_Request();
        }

        public void Success_Buy()
        {
            ProcessedOrders++;
            CountBooks--;
        }

        public void Check_Request()
        {
            for (int i = App._requests.Requests.Count - 1; i >= 0; i--)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    if (App._listBooks.ListBooks[App._requests.Requests[i].index].Count > 0)
                    {
                        App._market.BuyBook(App._requests.Requests[i].index, App._requests.Requests[i].Buyer);
                        Profit += App._market._assortmentBooks.GetAssortment()[App._requests.Requests[i].index].Price;
                        App._requests.Requests.RemoveAt(i);
                        Success_Buy();
                    }
                }); 
            }
        }
    }
}
