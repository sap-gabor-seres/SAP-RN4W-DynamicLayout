using Microsoft.ReactNative;
using Microsoft.ReactNative.Managed;
using UWPClassLibrary.UserControls;

namespace ReactNativeForWindowsDynamicLayout.ViewManagers
{
	internal class MyListViewViewManager : AttributedViewManager<MyListView>, IViewManagerRequiresNativeLayout
	{
		//public override string Name => "MyListViewWithItems";

		public bool RequiresNativeLayout => true;
	}
}
