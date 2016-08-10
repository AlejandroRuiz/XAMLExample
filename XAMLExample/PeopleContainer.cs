using System;
using System.Collections.ObjectModel;
using XAMLExample.Entity;
using XAMLExample.ViewModel;

namespace XAMLExample
{
	public static class PeopleContainer
	{
		public static ObservableCollection<UserVM> Records { get; } = new ObservableCollection<UserVM>();
	}
}

