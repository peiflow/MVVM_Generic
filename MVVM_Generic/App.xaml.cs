using GalaSoft.MvvmLight.Threading;
using ModuleGeneric.View;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Generic
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>

    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {

            DispatcherHelper.Initialize();

            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }

    //For PRISM v7
    //internal partial class App : PrismApplication
    //{
    //    protected override Window CreateShell()
    //    {
    //        return Container.Resolve<Shell>();
    //    }

    //    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    //    {
    //        containerRegistry.RegisterForNavigation<GenericModuleView>();
    //    }
    //}
}
