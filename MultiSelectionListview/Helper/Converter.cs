using System;
using System.Globalization;
using Xamarin.Forms;

namespace Mark21
{
	public class SelectedToColorConverter : IValueConverter
	{

		#region IValueConverter implementation

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
			{
				if ((Boolean)value)
					return Constant.selectedMachineLabelColor;
				else
					return Constant.UnselectedMachineLabelColor;
			}
			return Color.Black;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}


		#endregion
	}



}
