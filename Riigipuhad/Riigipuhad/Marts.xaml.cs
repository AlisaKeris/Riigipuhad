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
    public partial class Marts : ContentPage
    {
        Label lbl0;
        public Marts()
        {
            InitializeComponent();
            lbl0 = new Label()
            {
                Text = "14. märts – emakeelepäev",
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl0 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}