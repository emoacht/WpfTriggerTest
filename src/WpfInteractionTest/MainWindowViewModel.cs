using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace WpfInteractionTest
{
	public class MainWindowViewModel
	{
		public ICommand OnActivatedCommand { get; }
		public ICommand OnDeactivatedCommand { get; }
		public ICommand OnLoadedCommand { get; }

		public MainWindowViewModel()
		{
			OnActivatedCommand = new RelayCommand(() => Trace.WriteLine("AAA"));
			OnDeactivatedCommand = new RelayCommand(() => Trace.WriteLine("DDD"));
			OnLoadedCommand = new RelayCommand(() => Trace.WriteLine($"LLL"));
		}

		public void OnActivatedMethod()
		{
			Trace.WriteLine("AAAA");
		}
	}
}