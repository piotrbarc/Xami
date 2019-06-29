using System;
using System.IO;
using Xamarin.Forms;
using Xami.Models;
using Xami;

namespace Notes
{
	public partial class NoteEntryPage : ContentPage
	{
		public NoteEntryPage()
		{
			InitializeComponent();
		}

		async void OnSaveButtonClicked(object sender, EventArgs e)
		{
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