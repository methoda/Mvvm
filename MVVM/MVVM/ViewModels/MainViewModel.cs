using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Forms.Mvvm;

namespace MVVM.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ObservableCollection<Device> Devices;
        public MainViewModel()
        {
            Devices = new ObservableCollection<Device>();
            for (int i = 1; i <= 5; i++)
            {
                Devices.Add(new Device() { Name = "Iphone",Type="4" });
               

            }
        }
    }
}
