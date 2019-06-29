using System;
using SQLite;

namespace Xami.Models
{
	public class Note
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Text { get; set; }
		public DateTime Date { get; set; }
		public string Filename { get; internal set; }
	}
}
