using System;
using Android.Content;
using Android.Views;
using Mark21;
using Mark21.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomCell), typeof(CustomCellRenderer))]
namespace Mark21.Droid
{
	public class CustomCellRenderer : ViewCellRenderer
	{
		public CustomCellRenderer()
		{
		}

		protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
		{
			var cell = base.GetCellCore(item, convertView, parent, context);
			return cell;
		}

		protected override void OnCellPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{

			base.OnCellPropertyChanged(sender, e);
			var customCell = sender as CustomCell;
			if (e.PropertyName == CustomCell.isSelectedProperty)
			{
				customCell.View.BackgroundColor = Color.FromRgba(200, 54, 54, (float)0.5);
			}

		}
	}
}
