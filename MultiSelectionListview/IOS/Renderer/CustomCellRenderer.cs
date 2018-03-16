using System;
using Mark21;
using Mark21.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomCell), typeof(CustomCellRenderer))]
namespace Mark21.iOS
{
	public class CustomCellRenderer: ViewCellRenderer
	{
		private UIView view;


		public CustomCellRenderer()
		{
		}

		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var cell = base.GetCell(item, reusableCell, tv);

			if (view == null)
			{
				view = new UIView(cell.SelectedBackgroundView.Bounds);
				view.Layer.BackgroundColor = UIColor.FromRGBA(200, 54, 54, (float)0.5).CGColor;
			}
			cell.SelectedBackgroundView = view;
			return cell;
		}
	}
}
