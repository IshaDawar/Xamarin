using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace Mark21
{
	public partial class SelectMachines : ContentPage
	{
		public List<WrappedSelection<CheckItem>> WrappedItems;
		public SelectMachines()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
			var items = new List<CheckItem>();
			WrappedItems = new List<WrappedSelection<CheckItem>>();
			items.Add(new CheckItem { Name = "Xamarin.com" });
			items.Add(new CheckItem { Name = "Twitter" });
			items.Add(new CheckItem { Name = "Facebook" });
			items.Add(new CheckItem { Name = "Internet ad" });
			items.Add(new CheckItem { Name = "Online article" });
			items.Add(new CheckItem { Name = "Magazine ad" });
			items.Add(new CheckItem { Name = "Friends" });
			items.Add(new CheckItem { Name = "At work" });
			items.Add(new CheckItem { Name = "Xamarin.com" });
			items.Add(new CheckItem { Name = "Twitter" });
			items.Add(new CheckItem { Name = "Facebook" });
			items.Add(new CheckItem { Name = "Internet ad" });
			items.Add(new CheckItem { Name = "Online article" });
			items.Add(new CheckItem { Name = "Magazine ad" });
			items.Add(new CheckItem { Name = "Friends" });
			items.Add(new CheckItem { Name = "At work" });
			items.Add(new CheckItem { Name = "Xamarin.com" });
			items.Add(new CheckItem { Name = "Twitter" });
			items.Add(new CheckItem { Name = "Facebook" });
			items.Add(new CheckItem { Name = "Internet ad" });
			items.Add(new CheckItem { Name = "Online article" });
			items.Add(new CheckItem { Name = "Magazine ad" });
			items.Add(new CheckItem { Name = "Friends" });
			items.Add(new CheckItem { Name = "At work" });
			items.Add(new CheckItem { Name = "Xamarin.com" });

			WrappedItems = items.Select(item => new WrappedSelection<CheckItem>() { Item = item, IsSelected = false, IsNotSelected = true }).ToList();
			listview.ItemsSource = WrappedItems;
			listview.ItemSelected += (sender, e) =>
			{
				if (e.SelectedItem == null) return;
				var o = (WrappedSelection<CheckItem>)e.SelectedItem;
				o.IsSelected = !o.IsSelected;
				o.IsNotSelected = !o.IsNotSelected;
							
			};
			lblClrList.GestureRecognizers.Add(new TapGestureRecognizer
			{
				Command = new Command(( o =>
			   {
				   SelectNone();
			   }))
			});
		}
		void SelectNone()
		{
			foreach (var wi in WrappedItems)
			{
				wi.IsSelected = false;
				wi.IsNotSelected = true;
			}
		}
		public List<CheckItem> GetSelection()
		{
			return WrappedItems.Where (item => item.IsSelected).Select(wrappedItem => wrappedItem.Item).ToList();	
		}

		public class WrappedSelection<CheckItem> : INotifyPropertyChanged
		{
			public CheckItem Item { get; set; }
			bool isSelected = false;
			bool isNotSelected = false;
			public bool IsSelected
			{
				get
				{
					return isSelected;
				}
				set
				{
					if (isSelected != value)
					{
						isSelected = value;
						PropertyChanged(this, new PropertyChangedEventArgs("IsSelected"));
					}
				}
			}
			public bool IsNotSelected
			{
				get
				{
					return isNotSelected;
				}
				set
				{
					if (isNotSelected != value)
					{
						isNotSelected = value;
						PropertyChanged(this, new PropertyChangedEventArgs("IsNotSelected"));

					}
				}
			}
			public event PropertyChangedEventHandler PropertyChanged = delegate { };
		}


	}
}
