using System.Collections.ObjectModel;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace ListToGridView
{
	public partial class ListToGridViewPage : ContentPage
	{
		ObservableCollection<ImageList> list = new ObservableCollection<ImageList>();
		public ListToGridViewPage()
		{
			InitializeComponent();

			list.Add(new ImageList { ImageName = "image1.jpeg" });
			list.Add(new ImageList { ImageName = "image2.jpeg" });
			list.Add(new ImageList { ImageName = "image3.jpeg" });
			list.Add(new ImageList { ImageName = "imag4.jpeg" });
			list.Add(new ImageList { ImageName = "image1.jpeg" });
			list.Add(new ImageList { ImageName = "image2.jpeg" });
			list.Add(new ImageList { ImageName = "image3.jpeg" });
			list.Add(new ImageList { ImageName = "image1.jpeg" });
			list.Add(new ImageList { ImageName = "image2.jpeg" });
			list.Add(new ImageList { ImageName = "image3.jpeg" });
			list.Add(new ImageList { ImageName = "image2.jpeg" });
			list.Add(new ImageList { ImageName = "image3.jpeg" });
			list.Add(new ImageList { ImageName = "image1.jpeg" });
			list.Add(new ImageList { ImageName = "image2.jpeg" });
			list.Add(new ImageList { ImageName = "image3.jpeg" });
			list.Add(new ImageList { ImageName = "image2.jpeg" });
			list.Add(new ImageList { ImageName = "image3.jpeg" });
			list.Add(new ImageList { ImageName = "image1.jpeg" });
			list.Add(new ImageList { ImageName = "image2.jpeg" });
			list.Add(new ImageList { ImageName = "image3.jpeg" });
			list.Add(new ImageList { ImageName = "image1.jpeg" });
			list.Add(new ImageList { ImageName = "image2.jpeg" });
			list.Add(new ImageList { ImageName = "image3.jpeg" });
			imageList.FlowItemsSource = list;
			imageListView.ItemsSource = list;
			swit.Toggled += (sender, e) =>
			{
				if (swit.IsToggled)
				{
					imageList.IsVisible = true;
					imageListView.IsVisible = false;
					title.Text = "Grid Format Data";
				}
				else
				{
					imageList.IsVisible = false;
					imageListView.IsVisible = true;
					title.Text = "List Format Data";
				}
			};
		}

	}
}
