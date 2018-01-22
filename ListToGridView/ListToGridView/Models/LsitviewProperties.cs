using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListToGridView
{
	public class LsitviewProperties : INotifyPropertyChanged
	{
		private int ColumnCount;
		public int columnCount
		{
			get { return ColumnCount; }
			set
			{
				if (ColumnCount != value)
				{
					ColumnCount = value;
					OnPropertyChanged("columnCount");

				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged == null) return;
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}



	}
}
