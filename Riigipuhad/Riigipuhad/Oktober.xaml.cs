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
    public partial class Oktober : ContentPage
    {
        Label lbl0;
        public Oktober()
        {
            InitializeComponent();
            lbl0 = new Label()
            {
                Text = "17. oktoober – hõimupäev",
            }; 
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl0}
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}