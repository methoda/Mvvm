using MVVM.ViewModels;
using MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;

namespace MVVM
{
    public static class Setup
    {
        public static void Init()
        {
            try
            {
                var resolverContainer = new SimpleContainer();
                resolverContainer.Register<IDependencyContainer>(t => resolverContainer);
                Resolver.SetResolver(resolverContainer.GetResolver());
                InitViewFactory();
            }
            catch (Exception e)
            {

            }
        }
         static void InitViewFactory()
        {
            ViewFactory.Register<MainMVVMPage, MainViewModel>();
        }
    }
}
