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
    public partial class Jaanuar : ContentPage
    {
        public Jaanuar()
        {
            Label lbl1, lbl2;
            InitializeComponent();
            lbl1 = new Label()
            {
                Text = "1. jaanuar – uusaasta (kolmapäev)",
            }; lbl2 = new Label()
            {
                Text = "6. jaanuar – kolmekuningapäev",
            }; 
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl1, lbl2 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}