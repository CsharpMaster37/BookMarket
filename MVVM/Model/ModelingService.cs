using BookMarket.MVVM.Model.Interfaces;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<User> Users { get; set; }
        public ModelingService(int LV_timeDelivery, int UV_timeDelivery,int LV_threshold, int UV_threshold, int modelingPeriod, int modelingStep)
        {
            LowerValue_TimeDelivery = LV_timeDelivery;
            UpperValue_TimeDelivery = UV_timeDelivery;
            LowerValue_Threshold = LV_threshold;
            UpperValue_Threshold = UV_threshold;
            ModelingPeriod = modelingPeriod;
            ModelingStep = modelingStep;
        }
        public void Start_Modeling()
        {
            for(int i = 1; i<=ModelingPeriod; i++)
            {

                Day_Passed();
                if (i % ModelingStep == 0 || i == ModelingPeriod)
                    Step_Passed();
                if (IsStoped)
                    return;
            }
        }
        public void Step_Passed()
        {

        }
        public void Buy_Book()
        {

        }

        public void Check_Request()
        {
        }

        public void Day_Passed()
        {
        }

    }
}
