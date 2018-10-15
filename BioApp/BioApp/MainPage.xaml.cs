using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BioApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void AboutMeNavigation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMe());           
        }

        private void SkillsNavigation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Skills());
        }

        private void ContactMeNavigation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactMe());
        }
    }
}
