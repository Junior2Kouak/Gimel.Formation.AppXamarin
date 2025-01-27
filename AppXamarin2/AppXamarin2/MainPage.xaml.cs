using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXamarin2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Clicked";
     
        }

        private void OnPressed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundColor = Color.Blue;
        }

        private void OnReleased(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundColor = Color.Orange;
        }
    }
}
