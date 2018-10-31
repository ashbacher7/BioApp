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
            this.SkillsList.Add("C#");
            this.SkillsList.Add("");

            skillsListView.ItemSource = this.SkillsList;

        }        
    }
}