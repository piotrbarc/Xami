using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;

using Xami;
using Xami.Models;

namespace Notes
{
	public partial class NotesPage : ContentPage
	{

		string nameField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");
		string SubNameField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes2.txt");
		string PlaceField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes3.txt");
		string TeamField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes4.txt");
		public NotesPage()
		{
			InitializeComponent();
			if (File.Exists(nameField))
			{
				editor1.Text = "Witaj "+ File.ReadAllText(nameField);
			}

		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			if (File.Exists(nameField))
			{
				editor1.Text = "Witaj " + File.ReadAllText(nameField);
			}

			listView.ItemsSource =  await App.Database.GetNotesAsync();
		}

		async void AddShot(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NoteEntryPage
			{
				BindingContext = new Note()
			});
		}
		async void AddPerson(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new PersonPage());
		}
		async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				await Navigation.PushAsync(new NoteEntryPage
				{
					BindingContext = e.SelectedItem as Note
				});
			}
		}
	}
}