using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Riigipuhad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class December : ContentPage
    {
        Label lbl1,lbl2,lbl3;
        public December()
        {
            InitializeComponent();
            lbl1 = new Label()
            {
                Text = "24. detsember – jõululaupäev (neljapäev)",
            }; lbl2 = new Label()
            {
                Text = "25. detsember – esimene jõulupüha (reede)",
            }; lbl3 = new Label()
            {
                Text = "26. detsember – teine jõulupüha (laupäev)",
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl1,lbl2,lbl3 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}