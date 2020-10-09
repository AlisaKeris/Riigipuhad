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
            InitializeComponent();
            btn = new Button();
            btn.Clicked += Btn_Clicked1;
        }

        async void Btn_Clicked1(object sender, EventArgs e)
        {
            string answer = await DisplayActionSheet("Vali kuu", "Cancel", null, "Jaanuar", "Veebruar", "Marts", "April", "Mai", "Juuni", "Juuli", "August", "September", "Oktober", "November", "December");
        }
    }
}
