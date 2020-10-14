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
    public partial class November : ContentPage
    {
        Label lbl0, lbl1, lbl2;
        public November()
        {
            InitializeComponent();
            lbl0 = new Label()
            {
                Text = "2. november – hingedepäev",
            }; lbl1 = new Label()
            {
                Text = "8. november – isadepäev",
            }; lbl2 = new Label()
            {
                Text = "16. november – taassünnipäev",
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl0,lbl1,lbl2 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}