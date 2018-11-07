using MVVM_Generic.Infrastructure.Adapters;
using MVVM_Generic.ViewModel;
using Prism.Modularity;
using Prism.Regions;
using prun = Prism.Unity;
using System.Windows;
using System.Windows.Controls;
using miun = Microsoft.Practices.Unity;
using Microsoft.Practices.Unity;

namespace MVVM_Generic
{
    class Bootstrapper : prun.UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterType<ShellViewModel>();
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();
            mappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
            return mappings;
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }
    }
}
