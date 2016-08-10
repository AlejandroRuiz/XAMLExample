using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XAMLExample.ViewModel
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void OnPropertyChanged([CallerMemberName]string property = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(property));
			}
		}

		#endregion

		public BaseViewModel()
		{
		}
	}
}

