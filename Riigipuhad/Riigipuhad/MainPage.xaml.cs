using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Riigipuhad
{
    public partial class MainPage : TabbedPage
    {
        Button btn;
        public MainPage()
        {
            btn = new Button();
            btn.Clicked += Btn_Clicked1;
            StackLayout stackLayout = new StackLayout()
            {
                Children = {btn }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }

        private async void Btn_Clicked1(object sender, EventArgs e)
        {
           string answer = await DisplayActionSheet("Vali kuu", "Cancel", null, "Kevad", "Suvi", "Talv", "Sügis");
            if (answer == "Kevad")
            {
                
                   
            } else if (answer == "Suvi"){

            } else if (answer == "Sügis"){

            } else if (answer == "Talv")
            {

            }
        }
    }
}
