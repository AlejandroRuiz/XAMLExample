using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XAMLExample.ViewModel;

namespace XAMLExample
{
	public partial class EditUserPage : ContentPage
	{
		public EditUserPage(UserVM uservm)
		{
			BindingContext = uservm;
			InitializeComponent();
		}
	}
}

