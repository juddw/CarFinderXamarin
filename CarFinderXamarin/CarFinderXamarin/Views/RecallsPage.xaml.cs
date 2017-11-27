using Acr.UserDialogs;
using CarFinderXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarFinderXamarin.Views
{
    public partial class RecallsPage : ContentPage
    {
        public RecallsPage(string car, List<RecallResults> recallMsgList)
        {
            InitializeComponent();
            try
            {
                infoFor.Text += car;
                rclCount.Text += $"{recallMsgList.Count.ToString()} recalls";
                int counter = 1;
                foreach(var rclMsg in recallMsgList.Select(r => r.Summary))
                {
                    rclText.Text += $"{counter}. {rclMsg}";
                    counter++;
                }
            }
            catch(Exception ex)
            {
                UserDialogs.Instance.AlertAsync("Unable to get recalls: " + ex.Message);
            }
        }
    }
}