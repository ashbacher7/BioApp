using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Skills : ContentPage
	{
        public ObservableCollection<string> SkillsList { get; set; }
        public Skills ()
		{
			InitializeComponent ();

            this.SkillsList = new ObservableCollection<string>();
            this.SkillsList.Add("Experienced in C++ and Visual Basic");
            this.SkillsList.Add("Microsoft Excel 2013 Certified");
            this.SkillsList.Add("Quick learner.");
            this.SkillsList.Add("Work well in teams.");
            this.SkillsList.Add("Work until the job is completed.");


            skillsListView.ItemsSource = this.SkillsList;

           

        }        
    }
}