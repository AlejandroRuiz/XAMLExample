using Xamarin.Forms;
using XAMLExample.ViewModel;

namespace XAMLExample
{
	public partial class XAMLExamplePage : ContentPage
	{
		public XAMLExamplePage()
		{
			BindingContext = new MainPageVM();
			InitializeComponent();
		}
	}
}

