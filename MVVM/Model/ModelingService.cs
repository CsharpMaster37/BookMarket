using BookMarket.MVVM.Model.Books;
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
        public int Days_Passed { get; set; }
        public List<User> Users;
        public GenerationModelingService Generation_Serivce { get; set; }
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
        }
        public void Start_Modeling()
        {
            for(int i = 1; i<=ModelingPeriod; i++)
            {

                Next_Day();
                if (i % ModelingStep == 0 || i == ModelingPeriod)
                    Step_Passed();
                if (IsStoped)
                    return;
            }
        }
        public void Step_Passed()
        {

        }
        public void Next_Day()
        {
            Days_Passed++;
            foreach (Statement item in App._statement.Statement)
            {
                item.DeliveryTime--;
                //ToDo: Сделать удаление из Statement при 0
            }
            Check_Request();
        }

        public void Buy_Book()
        {
            Generation_Serivce.Generation_Buy(Users[random.Next(0, Users.Count-1)]);
        }

        public void Check_Request()
        {

        }

    }
}
