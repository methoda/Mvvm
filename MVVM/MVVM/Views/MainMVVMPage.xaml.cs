using MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XLabs.Forms.Mvvm;

namespace MVVM.Views
{
    public partial class MainMVVMPage : ContentPage
    {
        

        public MainMVVMPage()
        {
            InitializeComponent();
            
            list.HasUnevenRows = true;
            
        }

         
    }
}
