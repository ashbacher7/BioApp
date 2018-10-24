using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactMe : ContentPage
    {
        public ContactMe()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text))
            {
                DisplayAlert("Error", "Please enter a name.", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error", "Please enter an email address.", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(messageEditor.Text))
            {
                DisplayAlert("Error", "Please enter a message.", "Ok");
                return;
            }
            DisplayAlert("Alert", "Your message has been sent!", "Ok");
            return;
        }
    }
}