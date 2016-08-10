using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using XAMLExample.Entity;

namespace XAMLExample.ViewModel
{
	public class UserVM : BaseViewModel
	{

		Command _saveCommand;

		public Command SaveCommand
		{
			get
			{
				return _saveCommand ?? (_saveCommand = new Command(() => OnSaveMethod()));
			}
		}

		public async void OnSaveMethod()
		{
			await App.Current.MainPage.Navigation.PopModalAsync();
		}

		Command _editCommand;

		public Command EditCommand
		{
			get
			{
				return _editCommand ?? (_editCommand = new Command((obj) => OnEditMethod(obj as UserVM)));
			}
		}

		public async void OnEditMethod(UserVM uservm)
		{
			await App.Current.MainPage.Navigation.PushModalAsync(new EditUserPage(uservm));
		}

		Command _deleteCommand;

		public Command DeleteCommand
		{
			get
			{
				return _deleteCommand ?? (_deleteCommand = new Command((obj) => OnDeleteMethod(obj as UserVM)));
			}
		}

		public void OnDeleteMethod(UserVM uservm)
		{
			PeopleContainer.Records.Remove(uservm);
		}

		public string Name
		{
			get
			{
				return User.Name;
			}
			set
			{
				User.Name = value;
				OnPropertyChanged();
			}
		}

		public int Age
		{
			get
			{
				return User.Age;
			}
			set
			{
				User.Age = value;
				OnPropertyChanged();
			}
		}

		protected User User { get; set; }

		public UserVM(User @user)
		{
			User = @user;
		}
	}
}

