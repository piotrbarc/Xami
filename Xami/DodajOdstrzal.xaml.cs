﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Xami
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DodajOdstrzal : ContentPage
	{
		void Powrot(object sender, System.EventArgs e)
		{
			
			App.Current.MainPage = new MainPage();
		}


		string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

		public DodajOdstrzal()
		{
			InitializeComponent();

			if (File.Exists(_fileName))
			{
				editor.Text = File.ReadAllText(_fileName);
			}
		}

		void OnSaveButtonClicked(object sender, EventArgs e)
		{
			File.WriteAllText(_fileName, editor.Text);
		}

		void OnDeleteButtonClicked(object sender, EventArgs e)
		{
			if (File.Exists(_fileName))
			{
				File.Delete(_fileName);
			}
			editor.Text = string.Empty;
		}
	}
}


