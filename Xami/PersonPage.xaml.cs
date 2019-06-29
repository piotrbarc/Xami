using Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xami.Models;

namespace Xami
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PersonPage : ContentPage
	{
		public PersonPage()
		{
			InitializeComponent();
		}

		private async void SavePerson(object sender, EventArgs e)
		{
		
		messageLabel.Text = "saa";
		await Navigation.PushAsync(new NotesPage());
			
		}

		
	}
}