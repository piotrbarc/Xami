using System;
using System.IO;
using Xamarin.Forms;

namespace Xami
{
	public partial class PersonPage : ContentPage
	{
		string nameField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");
		string SubNameField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes2.txt");
		string PlaceField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes3.txt");
		string TeamField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes4.txt");


		public PersonPage()
		{
			InitializeComponent();

			
				
					editor1.Text = File.ReadAllText(nameField);
				editor2.Text = File.ReadAllText(SubNameField);
				editor3.Text = File.ReadAllText(PlaceField);
			editor4.Text = File.ReadAllText(TeamField);


		}

		void OnSaveButtonClicked(object sender, EventArgs e)
		{
			File.WriteAllText(nameField, editor1.Text);
			File.WriteAllText(SubNameField, editor2.Text);
			File.WriteAllText(PlaceField, editor3.Text);
			File.WriteAllText(TeamField, editor4.Text);
		}

		
	}
}