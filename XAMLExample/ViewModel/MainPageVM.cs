using System;
using Xamarin.Forms;
using XAMLExample.Entity;

namespace XAMLExample.ViewModel
{
	public class MainPageVM : BaseViewModel
	{
		public MainPageVM()
		{
		}

		Command _addCommand;

		public Command AddCommand
		{
			get
			{
				return _addCommand ?? (_addCommand = new Command(() => OnAddMethod()));
			}
		}

		public async void OnAddMethod()
		{
			var uservm = new UserVM(new User());
			PeopleContainer.Records.Add(uservm);
			await App.Current.MainPage.Navigation.PushModalAsync(new EditUserPage(uservm));
		}
	}
}

