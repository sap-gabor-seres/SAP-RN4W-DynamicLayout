using Microsoft.ReactNative;
using Microsoft.ReactNative.Managed;
using UWPClassLibrary.UserControls;

namespace ReactNativeForWindowsDynamicLayout.ViewManagers
{
	// TODO: IViewManagerCreateWithProperties - not used in mdk-win
	internal class MyTextBoxViewManager : AttributedViewManager<MyTextBox>, IViewManagerRequiresNativeLayout
	{
		public override string Name => "MyMultilineTextBox";

		public bool RequiresNativeLayout => true;

		//public override FrameworkElement CreateView()
		//{
		//	MyTextBox uc = new MyTextBox();
		//	return uc;
		//}
	}
}
