﻿using System;
using System.IO;
using Xamarin.Forms;
using Xami.Models;
using Xami;

namespace Notes
{
	public partial class NoteEntryPage : ContentPage
	{

		string nameField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");
		string SubNameField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes2.txt");
		string PlaceField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes3.txt");
		string TeamField = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes4.txt");
		public NoteEntryPage()
		{
			InitializeComponent();
		}
		
		async void OnSaveButtonClicked(object sender, EventArgs e)
		{
		//	string Wizytowka = "Wpis dodał" + File.ReadAllText(nameField) + " " + File.ReadAllText(SubNameField) + "z" + File.ReadAllText(PlaceField) + "należący do koła" + File.ReadAllText(TeamField);
			var note = (Note)BindingContext;
			note.Date = DateTime.UtcNow;
			await App.Database.SaveNoteAsync(note);
			await Navigation.PopAsync();
		}

		async void OnDeleteButtonClicked(object sender, EventArgs e)
		{
			var note = (Note)BindingContext;
			await App.Database.DeleteNoteAsync(note);
			await Navigation.PopAsync();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NotesPage());
		}
	}
}