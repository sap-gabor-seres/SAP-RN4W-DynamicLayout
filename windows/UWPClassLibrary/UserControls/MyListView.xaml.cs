using System.Collections.ObjectModel;
using System.Linq;
using UWPClassLibrary.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UWPClassLibrary.UserControls
{
	public sealed partial class MyListView : UserControl
	{
		public MyListView()
		{
			InitializeComponent();

			ListItems = new ObservableCollection<ListViewModel>();
		}

		public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register("ListItems", typeof(ObservableCollection<ListViewModel>), typeof(MyListView), new PropertyMetadata(null));
		public ObservableCollection<ListViewModel> ListItems
		{
			get => (ObservableCollection<ListViewModel>)GetValue(ItemsProperty);
			set => SetValue(ItemsProperty, value);
		}

		private void AddItem_Click(object sender, RoutedEventArgs e)
		{
			ListViewModel modelItem = new ListViewModel()
			{
				Value = $"Value {ListItems.Count + 1}",
			};

			ListItems.Add(modelItem);
		}

		private void RemoveItem_Click(object sender, RoutedEventArgs e)
		{
			if (ListItems.Any())
			{
				ListItems.Remove(ListItems.Last());
			}
		}
	}
}
