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
    public partial class August : ContentPage
    {
        Label lbl1;
        public August()
        {
            InitializeComponent();
            lbl1 = new Label()
            {
                Text = "20. august – taasiseseisvumispäev (neljapäev)",
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl1 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}