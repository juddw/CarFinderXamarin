using CarFinderXamarin.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarFinderXamarin
{
    public partial class App : Application
    {
        private MainPage mp = new MainPage();
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(mp);
        }

        protected async override void OnStart()
        {
            // Handle when your app starts
            Picker years = mp.Content.FindByName<Picker>("pickerYears");
            mp.BackgroundImage = "carbkgd.jpg";

            CarService svcCar = new CarService();

            List<string> yrs = await svcCar.GetYears();
            foreach (string y in yrs)
            {
                if(y != null)
                {
                    years.Items.Add(y);
                }
            }
        }
    }
}