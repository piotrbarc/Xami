using Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
			await Navigation.PushAsync(new NotesPage());
		}
	}
}